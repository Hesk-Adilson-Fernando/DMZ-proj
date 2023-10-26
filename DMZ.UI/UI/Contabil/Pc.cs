using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class Pc : FrmClasse
    {
        private Pgc _pgc;
        private string _contalist;

        public Pc()
        {
            InitializeComponent();
        }
        public static void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.Invokex(x=>x.ShowAlert(msg, type));
        }
        public decimal Posicao { get; set; }
        private void Pc_Load(object sender, EventArgs e)
        {
            Ctabela = "pgc";
            Campo1 = "conta";
            Campo2 = "descricao";
            CCondicao=" ano= (select ano from param)";
            Posicao=SQL.GetValue("Posicao","param").ToDecimal();
            PopulateTreeview();
        }
        private void PopulateTreeview()
        {
            var str = "select conta,descricao,ano,pgcstamp,integracao, ok=Cast( 0 as bit) from pgc where ano =(select ano from param) order by conta";
            DtContas = SQL.GetGen2DT(str);
            //DtContas.AddEmptyRow();
            gridProcessdetails.SetDataSource(DtContas);
        }

        public DataTable DtContas { get; set; }

        public override void DefaultValues()
        {
            _pgc = DoAddline<Pgc>();
            tbAno.tb1.Text = Pbl.AnoContabil().ToString();
            base.DefaultValues();
        }
        public override bool CheckDelete()
        {
            var dt = SQL.GetGenDT($@"select top 1 Conta from ml join Lcont on Lcont.Lcontstamp =ml.Lcontstamp 
            where conta = '{tbConta.tb1.Text.Trim()}' and Lcont.ano ={Pbl.AnoContabil()}");
            if (!(dt?.Rows.Count > 0)) return base.CheckDelete();
            MsBox.Show($"Descupla mas a conta: \r\n {tbConta.tb1.Text} tem movimentos lançados. já não se pode eliminar!.. ");
            return false;
        }
        public override bool BeforeSave()
        {
            if (Procurou) return base.BeforeSave();
            var dt =SQL.GetGenDT($"select conta from pgc where conta ='{tbConta.tb1.Text.Trim()}' and ano={Pbl.AnoContabil()}");
            if (dt.Rows.Count <= 0) return base.BeforeSave();
            MsBox.Show($"Já existe a conta {tbConta.tb1.Text} no ano {Pbl.AnoContabil()}");
            return false;
        }

        public override void Save()
        {
            base.Save();
            FillEntity(_pgc);
            if (Cancelado) return;
            if (EF.Save(_pgc).ret != 1) return;
            GenBl.ExecAudit(_pgc, Name,true);
            PopulateTreeview();
        }


        public override void PreencheCampos(DataTable dt, int i)
        {
            _pgc = FillControls(_pgc, dt, i);
        }
        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            Menu.ShowMenuStrip(btnMenuLateral);
        }

        private void Extrato_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbConta.tb1.Text))
            {
                var p = new PgcExtrato
                {
                    Conta = tbConta.tb1.Text,
                    Descritivo=tbDescritivo.tb1.Text
                };
                p.ShowForm(this);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"Deve seleçionar uma conta primeiro!..");
            }
        }

        public string OrigemTabela { get; set; }
        public string Deletestamp { get; set; }
        public string Deleteconta { get; set; }
        public override bool BeforeDelete()
        {
            OrigemTabela = _pgc.Ppconta;
            Deletestamp = _pgc.Pgcstamp;
            Deleteconta = _pgc.Conta;
            return base.BeforeDelete();
        }

        private void Pc_AfterDelete()
        {
            if (!string.IsNullOrEmpty(OrigemTabela))
            {
                Integracao.Apagar(Deleteconta,OrigemTabela);
            }
            PopulateTreeview();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PopulateTreeview();
        }

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                var p = new FrmPcLista();
                p.Condicao=$"ano={Pbl.AnoContabil()}";
                p.ShowForm(this);
        }

        private void Saldos_Click(object sender, EventArgs e)
        {

        }

        private void gridProcessdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProcessdetails.CurrentRow != null)
                if (!gridProcessdetails.CurrentCell.OwningColumn.Name.Equals("ok"))
                {
                    var stamp = gridProcessdetails.CurrentRow.Cells["pgcstamp"].Value.ToString().Trim();
                    var dt = SQL.GetGen2DT($"select * from pgc where pgcstamp='{stamp}'");
                    PreencheCampos(dt, 0);
                    Procurou = true;
                }
                else
                {
                    gridProcessdetails.CurrentCell.Value = !(gridProcessdetails.CurrentCell.Value is DBNull) && !gridProcessdetails.CurrentCell.Value.ToBool();//aqui seta o true ou false quando clica manualmente 
                    gridProcessdetails.Update();
                }
        }

        private void gridProcessdetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridProcessdetails == null) return;
            var cell1 = gridProcessdetails[gridProcessdetails.Columns["integracao"].Index, e.RowIndex];
            if (!cell1.Value.ToBool()) return;
            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja eliminar a(s) conta(s)?",DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            gridProcessdetails.Update();
            if (gridProcessdetails.GetBindedTable().HasRows("ok"))
            {
                var tabela = gridProcessdetails.GetBindedTable().HasRowsCopyToDataTable("ok");
                Helper.DoProgressProcess(tabela, RecebeDados, "descricao","Eliminando conta");
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve selecçionar a(s) conta(s) desejada(s)!");
            }
        }
        private void RecebeDados(DataRow dr, bool fim)
        {
            if (dr["integracao"].ToBool()) return;
            if (!CheckMovimentos(dr["conta"].ToString().Trim()))
            {
                SQL.SqlCmd($"delete from pgc where pgcstamp ='{dr["pgcstamp"].ToString().Trim()}'");
                //if (_stamplist.IsNullOrEmpty())
                //{
                //    _stamplist = $"'{dr["pgcstamp"]}'";
                //}
                //else
                //{
                //    _stamplist += $",'{dr["pgcstamp"]}'";
                //}
                if (fim)
                {
                    Alert("Conta(s) eliminada(s) com sucesso!", Form_Alert.EnmType.Success);
                    PopulateTreeview();
                    //if (SQL.SqlCmd($"delete from pgc where pgcstamp in({_stamplist})") > 0)
                    //{
                    //    _stamplist = "";
                    //    Alert("Conta(s) eliminada(s) com sucesso!", Form_Alert.EnmType.Success);
                    //    PopulateTreeview();
                    //    if (!_contalist.IsNullOrEmpty())
                    //    {
                    //        MsBox.Show(Messagem.ParteInicial() + $"As seguintes conta(s) não foi(ram) eliminada(s) porque foram movimentada(s)!\r\n{_contalist}");
                    //    }
                    //}
                }
            }
            else
            {
                if (_contalist.IsNullOrEmpty())
                {
                    _contalist = $"{dr["conta"]}\r\n";
                }
                else
                {
                    _contalist += $",{dr["conta"]}";
                }
            }
        }

        private bool CheckMovimentos(string conta)
        {
            return SQL.CheckExist($"select conta from ml where conta ='{conta.Trim()}'");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Inserindo)
            {
                btnNovo.PerformClick();
                if (gridProcessdetails.GetBindedTable().HasRows("ok"))
                {
                    var tabela = gridProcessdetails.GetBindedTable().HasRowsCopyToDataTable("ok");
                    var dr = tabela.Rows[0];
                    tbAno.tb1.Text = dr["ano"].ToString();
                    tbConta.tb1.Text = dr["conta"].ToString();
                    tbDescritivo.tb1.Text = dr["descricao"].ToString();
                    cbIntegradora.Update(dr["ano"].ToBool());
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "Deve selecçionar a conta de base desejada!");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "O formulario está em modo de edição!");
            }
        }

        private void gridProcessdetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void gridProcessdetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (gridProcessdetails.CurrentRow == null) return;
            //if (gridProcessdetails.CurrentRow.Index == 0)
            //{
            //    var col = gridProcessdetails.CurrentCell.OwningColumn.DataPropertyName;
            //    if (!col.Equals("ok") && !col.Equals("integracao"))
            //    {
            //        Helper.UpdateGrid(false, gridProcessdetails, DtContas, gridProcessdetails.CurrentCell.Value.ToString(), gridProcessdetails.CurrentCell.OwningColumn.DataPropertyName,true);
            //    }
            //}
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridProcessdetails, DtContas, tbProcura.Text,"conta");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridProcessdetails, DtContas, textBox1.Text, "descricao");
        }
    }
}
