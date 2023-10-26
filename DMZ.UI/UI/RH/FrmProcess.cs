using System;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Reports;
using DMZ.UI.Extensions;
using DMZ.UI.UC;

namespace DMZ.UI.UI.RH
{
    public partial class FrmProcess : FrmClasse2
    {
        public Proces Proces { get; set; }
        public DataTable QryPrc { get; set; }
        public DataTable Peempcc { get; set; }
        public DataTable RclMvt { get; set; }
        public string CLocalStamp { get; private set; }

        public FrmProcess()
        {
            InitializeComponent();
        }
        private void FrmProcess_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Pbl.SqlDate.Year;
            BindGrid();
            tbCCusto.tb1.Text = Pbl.CCu.Descricao;
            tbCCusto.Text2 = Pbl.CCu.Ccustamp;
        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        void BindGrid()
        {
            QryPrc = SQL.Initialize("prc");
            gridProcessdetails.DataSource = null;
            gridProcessdetails.AutoGenerateColumns = false;
            gridProcessdetails.DataSource = QryPrc;
        }

        private void btnAddprocess_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddProcess
            {
                SendInfo = ReceiveInfo,
                QryPrc = QryPrc
            };
            frm.ShowForm(this, true);
            //if (Pbl.RhsExpirado)
            //{
            //    MsBox.Show(Messagem.ParteInicial() + $"A VERSÃO {Pbl.VersaoActivo} EXPRIROU \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //}
            //else
            //{
            //    var frm = new FrmAddProcess
            //    {
            //        SendInfo = ReceiveInfo,
            //        QryPrc = QryPrc
            //    };
            //    frm.ShowForm(this, true);
            //}
        }

        private void ReceiveInfo(DataTable QryPrc,Proces proces)
        {
            Limpar();
            PreecherGrid(QryPrc);
            Proces = proces;
            if (proces == null) return;
            Preecher(proces);
            EditMode = false;
            CLocalStamp = Proces.Processtamp;
        }
        private void PreecherGrid(DataTable qryPrc)
        {
            gridProcessdetails.SetDataSource(qryPrc);
        }

        private void Preecher(Proces proces)
        {
            tbDescricao.Text = proces.Descricao;
            tbMes.tb1.Text = proces.Mes;
            tbPeriodo.tb1.Text = proces.Periodo;
            tbNumero.Text = proces.Codigo.ToString();
            tbCCusto.tb1.Text = proces.CCusto;
            tbTipoVenc.tb1.Text = proces.Tipoproces;
            tbObs.Text = proces.Obs;
            tbVencimento.Text = proces.TotalBaseVencimento.ToString("N2");
            tbSub.Text = proces.TotalSubsidio.ToString("N2");
            tbAlimentacao.Text=proces.TotalAliment.ToString("N2");
            tbSeguranca.Text=proces.TotalSegSocfunc.ToString("N2");
            tbHextras.Text=proces.TotalHextra.ToString("N2");
            tbDescontos.Text=proces.TotalDesconto.ToString("N2");
            tbLiquido.Text=proces.Totalliquido.ToString("N2");
            tbInssempresa.Text=proces.TotalSegSocEmp.ToString("N2");
            tbFaltas.Text = proces.TotalFaltas.ToString("N2");
            tbIRPS.Text= proces.TotalIrps.ToString("N2");
        }

        private void gridProcessdetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridProcessdetails == null) return;
            var cell1 = gridProcessdetails[gridProcessdetails.Columns["Linhatotal"].Index, e.RowIndex];
            if (!cell1.Value.ToBool()) return;
            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
        }
        bool IsTheSameCellValue(int column, int row)
        {
            var cell1 = gridProcessdetails[column, row];
            var cell2 = gridProcessdetails[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void gridProcessdetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = gridProcessdetails.AdvancedCellBorderStyle.Top;
            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (EditMode) return;
            var dr = MsBox.Show("Deseja gravar o processamento!",DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            if (tbCCusto.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show("Deve indicar o centro de custo");
                return;
            }
            if (!string.IsNullOrEmpty(tbObs.Text))
            {
                Proces.Obs = tbObs.Text;
            }
            if (EF.Save(Proces).ret>0)
            {
                var dt = gridProcessdetails.GetBindedTable();
                var retorno=SQL.Save(dt, "prc", true, Proces.Processtamp, "Proces");
                if (retorno.numero>0)
                {
                    foreach (var r in dt.AsEnumerable())
                    {
                        if (r!= null)
                        {
                            if (!r["Pehextrastamp"].ToString().IsNullOrEmpty())
                            {
                                var Pehextra = SQL.GetRowToEnt<Pehextra>($"Pehextrastamp='{r["Pehextrastamp"].ToString().Trim()}'");//EF.GetEnt<Pehextra>(x=>x.Pehextrastamp.Trim().Equals(r["Pehextrastamp"].ToString().Trim()));
                                if (Pehextra!=null)
                                {
                                    Pehextra.Processado = true;
                                    Pehextra.DataProc = Pbl.SqlDate;
                                    Pehextra.ValorProc = r["valor"].ToDecimal().ToRound(2);
                                    Pehextra.Prcstamp = r["Prcstamp"].ToString().Trim();
                                    Pehextra.Processtamp = Proces.Processtamp;
                                    EF.Save(Pehextra);
                                }                        
                            }
                            if (!r["pefaltastamp"].ToString().IsNullOrEmpty())
                            {
                                var Pefalta = SQL.GetRowToEnt<Pefalta>($"Pefaltastamp='{r["Pefaltastamp"].ToString().Trim()}'");// EF.GetEnt<Pefalta>(x => x.Pefaltastamp.Trim().Equals(r["Pefaltastamp"].ToString().Trim()));
                                if (Pefalta != null)
                                {
                                    Pefalta.Processado = true;
                                    Pefalta.DataProc = Pbl.SqlDate;
                                    Pefalta.Total = r["valor"].ToDecimal().ToRound(2);
                                    Pefalta.Prcstamp = r["Prcstamp"].ToString().Trim();
                                    Pefalta.Processtamp = Proces.Processtamp;
                                    Pefalta.AnoProcessado = numericUpDown1.Value;
                                    EF.Save(Pefalta);
                                }
                            }
                        }
                    }
                    MsBox.Show("Processamento Gravado com sucesso!");
                }
                else
                {
                    MsBox.Show(retorno.messagem);
                }
            }
            else
            {
                MsBox.Show("Operação não gravada, tente novamente!");
            }
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Procurar("codigo");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MenuPrint.ShowMenuStrip(btnPrint);
        }
        
        private void Procurar(string Value)
        {
            if (!string.IsNullOrEmpty(Value))
            {
                var tabela = "proces";
                var dt = SQL.GetGenDT($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE COLUMN_NAME='{Value}' and TABLE_NAME ='{tabela}' ");
                if (dt.Rows.Count > 0)
                {
                    var campo1 = "codigo";
                    var campo2 = "Descricao";
                    var form = Application.OpenForms["Proc2"];
                    if (form != null)
                    {
                        form.Dispose();
                        ProcedForm(tabela, campo1, campo2,Value,$"year(data)={Pbl.SqlDate.Year}");
                    }
                    else
                    {
                        ProcedForm(tabela, campo1, campo2,Value, $"year(data)={Pbl.SqlDate.Year}");
                    }
                }
                else
                {
                    MsBox.Show(@"Parâmetros não configurados!");
                }
            }
            else
            {
                MsBox.Show(@"Parâmetros não configurados!");
            }
        }

        private void ProcedForm(string tabela, string campo1, string campo2,string Value, string Condicao)
        {
            var P2 = new Proc2(tabela, campo1, campo2, Value, Condicao)
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(450, 100),
                PControl = PassData,
                Text = @"Procurar Processamento",
                DataNome = "data",
                Campo1Capition ="Código",
                Campo2Capition ="Descrição",
                //OrderByCampos = "no,tipo",
                Multidocumento = true,
                TodosCentros=true
            };
            P2.ShowDialog();
            P2.ShowInTaskbar = true;
        }
        private void PassData(object sender, int posicao)
        {
            var dt = (DataTable) sender;
            if (!dt.HasRows()) return;
            var result = Helper.GetTableByIndex(dt,posicao);
            Proces = result.DtToList<Proces>().First();
            if (Proces == null) return;
            Preecher(Proces);
            QryPrc = SQL.GetDT("prc", $"Processtamp ='{Proces.Processtamp.Trim()}'  order by no,tipo");
            PreecherGrid(QryPrc);
            EditMode = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Procurar("periodo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procurar("mes");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            var dr = MsBox.Show(Messagem.ParteInicial()+"Deseja eliminar o processamento?",DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            if (SQL.Apagar("proces", Proces.Processtamp.Trim())==1)
            {
                var dt = gridProcessdetails.GetBindedTable();
                if (dt.HasRows())
                {
                    foreach (var r in dt.AsEnumerable())
                    {
                        if (r != null)
                        {
                            if (!r["Pehextrastamp"].ToString().IsNullOrEmpty())
                            {
                                var Pehextra = SQL.GetRowToEnt<Pehextra>($"Pehextrastamp='{r["Pehextrastamp"].ToString().Trim()}'");//EF.GetEnt<Pehextra>(x => x.Pehextrastamp.Trim().Equals(r["Pehextrastamp"].ToString().Trim()));
                                if (Pehextra != null)
                                {
                                    Pehextra.Processado = false;
                                    Pehextra.DataProc = new DateTime(1900,1,1);
                                    Pehextra.ValorProc = 0;
                                    Pehextra.Prcstamp = "";
                                    Pehextra.Processtamp = "";
                                    EF.Save(Pehextra);
                                }
                            }
                            if (!r["pefaltastamp"].ToString().IsNullOrEmpty())
                            {
                                var Pefalta = SQL.GetRowToEnt<Pefalta>($"Pefaltastamp='{r["Pefaltastamp"].ToString().Trim()}'");//EF.GetEnt<Pefalta>(x => x.Pefaltastamp.Trim().Equals(r["Pefaltastamp"].ToString().Trim()));
                                if (Pefalta != null)
                                {
                                    Pefalta.Processado = false;
                                    Pefalta.DataProc = new DateTime(1900, 1, 1);
                                    Pefalta.Total = 0;
                                    Pefalta.Prcstamp = "";
                                    Pefalta.Processtamp = "";
                                    Pefalta.AnoProcessado = 0;
                                    EF.Save(Pefalta);
                                }
                            }
                        }
                    }
                }
            }
            MsBox.Show(Messagem.ParteInicial()+"processamento eliminado com sucesso");
            Limpar();
        }

        private void Limpar()
        {
            var controls = Helper.GetAll(this, typeof(TextBox)).ToList();
            if (controls.Count>0)
            {
                foreach (TextBox tb in controls)
                {
                    if (tb !=null)
                    {
                        tb.Text = "";
                    }
                }              
            }
            var controls2 = Helper.GetAll(this, typeof(DmzProcura)).ToList();
            if (controls2.Count>0)
            {
                foreach (DmzProcura item in controls2)
                {
                    if (item != null)
                    {
                        item.tb1.Text = "";
                    }
                }
            }
            var dt = gridProcessdetails.DataSource as DataTable;
            if (!(dt?.Rows.Count > 0)) return;
            dt.Rows.Clear();
            gridProcessdetails.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Procurar("Tipoproces");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Procurar("ccusto");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            BindMapa("RESUMIDA");
        }

        private void BindMapa(string origem)
        {
            if (Proces!=null)
            {
                var dr = SQL.GetRow("Querry,Reportname,DESCRICAO,XmlString,Tamanho", "Rltsql", $"Origem='{origem.Trim()}'");
                if (dr != null)
                {
                    var qry = string.Format(dr["Querry"].ToString().Trim(), Proces.Processtamp);
                    if (!dr["Reportname"].ToString().IsNullOrEmpty())
                    {
                        Doform(qry, dr["DESCRICAO"].ToString().ToLower().Trim(),
                            dr["Reportname"].ToString().Trim(), 
                            dr["XmlString"].ToString().Trim(),
                            dr["Tamanho"].ToString().Trim());
                    }
                    else
                    {
                        MsBox.Show($"Software não encontrou nenhum ficheiro de Impressão, para o parametro {origem.ToUpper()}");
                    }
                }
                else
                {
                    MsBox.Show($"Software não encontrou nenhum QUERY, para o parametro {origem.ToUpper()}");
                }
            }
            else
            {
                MsBox.Show($"Software não encontrou nenhum QUERY, para o parametro {origem.ToUpper()}");
            }

        }

        private void nORMALDIRECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindMapa("BANCO");
        }

        private void Doform(string qry, string titulo,string ReportName, string XmlString,string descricaotitulo)
        {
            var dtprc = SQL.GetGen2DT(qry);
            var cft = $"FOLHA DE SALÁRIO DO MÊS DE:  {tbMes.tb1.Text.ToUpper()} - {titulo.ToUpper()}";
            if (!descricaotitulo.IsNullOrEmpty())
            {
                cft = $"{descricaotitulo} {tbMes.tb1.Text.ToUpper()} - {titulo.ToUpper()}";
            }
            DS ds = new DS();
            var ret = Imprimir.FillData(null, dtprc, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, 
                label1.Text, "",
                ReportName, "SAL", 
                this, XmlString, true, ds,
                cft,
                cft
                );
        }
        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindMapa("DETALHADA");
        }
        private void pAGAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindMapa("PAGAMENTO");
        }

        private void pAGAMENTOINSSDETALHADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindMapa("INSSDETALHADO");
        }

        private void pAGAMENTOIRPSDETALHADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MsBox.Show(Messagem.ParteInicial() + "Mapa não configurado!");
        }

        private void pAGAMENTOIRPSDETALHADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MsBox.Show(Messagem.ParteInicial() + "Mapa não configurado!");
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(cbDefault1.cb1.Checked, gridProcessdetails, QryPrc, tbProcura.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
