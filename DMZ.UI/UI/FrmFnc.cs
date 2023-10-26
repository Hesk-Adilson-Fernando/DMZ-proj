using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using System.Globalization;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmFnc : Basic.FrmClasse
    {
        public FrmFnc()
        {
            InitializeComponent();
        }
        public Fnc _fnc;
        private void FrmFnc_Load(object sender, EventArgs e)
        {
            Campo1 = "no";
            Campo2 = "nome";
            Ctabela = "fnc";
        }

        public override void DefaultValues()
        {
            _fnc = DoAddline<Fnc>();
            base.DefaultValues();
            Helper.SetMaxNumero(tbNumero,"fnc");
            status.SetStatusValue();

            CriarContasContabilidade();
            //select upper(Descricao) Descricao from Auxiliar where Tabela=76 ORDER BY Codigo
            using (var dt = SQL.GetGen2DT("select upper(Descricao) Descricao from Auxiliar where Tabela=76 ORDER BY Codigo"))
            {
                gridUi2.DataSource = null;
                if (dt != null)
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        gridUi2.AddLine();
                        gridUi2.DtDS.Rows[gridUi2.DtDS.Rows.Count - 1]["criterio"] =
                            dt.Rows[i]["Descricao"].ToString();
                    }
            }
            gridUi2.AutoGenerateColumns = false;
            gridUi2.DataSource = gridUi2.DtDS;
        }
    
        public override void Save()
        {
            FillEntity(_fnc);
            EF.Save(_fnc);
        }
        public override void AfterSave()
        {
            Helper.GravaConta(gridContasCT.DtDS,_fnc.Fncstamp,_fnc.Nome,"fncct");
            if (!string.IsNullOrEmpty(Conta) && !string.IsNullOrEmpty(_fnc.Fncstamp))
            {
                Integracao.UpdatePGC(Conta,_fnc.Fncstamp);
            }
            base.AfterSave();
            int conta = 0;
            for (int i = 0; i < gridUi2.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(gridUi2.Rows[i].Cells["grau"].Value.ToString())
                    || !string.IsNullOrEmpty(gridUi2.Rows[i].Cells["Avaliacao"].Value.ToString()))
                {

                    conta += 1;
                }
            }
            //Serve para verificar se este fornecedor foi classificado ou não
            //se conta=0, então não foi definido nenhum critério
            if (conta == 0)
            {
                SQL.SqlCmd($"delete from FncProc where fncstamp='{CLocalStamp}'");
            }
        }
       
        public override bool CheckDelete()
        {
            var dt = SQL.GetGenDT($"select top 1 no from facc where no ={tbNumero.tb1.Text.ToDecimal()}");
            if (!(dt?.Rows.Count > 0)) return base.CheckDelete();
            MsBox.Show($"Descupla mas o fornecedor: \r\n {tbNome.tb1.Text} tem facturas emitidas já não se pode eliminar!.. ");
            return false;
        }

        public override void PreencheCampos(DataTable dts, int ii)
        {
            _fnc = FillControls(_fnc, dts, ii);
            GetCC(); 
            if (gridUi2.Rows.Count == 0)
            {
                var dt = SQL.GetGen2DT("select upper(Descricao) Descricao from Auxiliar where Tabela=76 ORDER BY Codigo");

                gridUi2.DataSource = null;
                if (dt != null)
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        gridUi2.AddLine();
                        gridUi2.DtDS.Rows[gridUi2.DtDS.Rows.Count - 1]["criterio"] =
                            dt.Rows[i]["Descricao"].ToString();
                    }
                gridUi2.AutoGenerateColumns = false;
                gridUi2.DataSource = gridUi2.DtDS;
            }
        }
        private void GetCC()
        {
            var dtcc = SQL.GetGen2DT($"select moeda,sum(valorreg) as saldo from FNCCCF() where fncstamp='{CLocalStamp}' group by Moeda order by moeda  ");
            gridCc.SetDataSource(dtcc);
        }
        private void CriarContasContabilidade()
        {
            var ct = SQL.GetDT("EmpresaMod", "sigla", "Sigla='CT'",null);
            if (!(ct?.Rows.Count > 0)) return;
            if (!SQL.GetField("Criafnc","param").ToBool()) return;
            var dt = SQL.GetGenDT("select * from Paramgct where codtipo=2");
            if (!(dt?.Rows.Count > 0)) return;
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                if (!r["grupo"].Equals("421")) continue;
                Helper.CriaConta(r,gridContasCT,tbNumero.tb1.Text);
            }
        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            Menulateral.ShowMenuStrip(btnMenuLateral);
        }

        private void btnCcorrente_Click(object sender, EventArgs e)
        {
               ChamaRelatorios();
        }
        private void ChamaRelatorios()
        {
            var f = new FrmRelatorios{Modulo = "GES"};
            f.label1.Text = @"CONTA CORRENTE DO FORNECEDOR";
            f.CondicaoOrigem="and Mostracfe =2";
            f.ShowForm(this);
        }
        private void AbrirCC()
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                var dt = EntBl.GetExtrato(tbNumero.tb1.Text,"","",false,"");
                if (dt?.Rows.Count>0)
                {
                    var f = new FrmCcCl { Tabela = dt,tbNome = { Text = tbNome.tb1.Text },tbNumero = { Text = tbNumero.tb1.Text }};
                    var deb= dt.AsEnumerable().Sum(x => x.Field<decimal?>("debito")).ToString();
                    var cre= dt.AsEnumerable().Sum(x => x.Field<decimal?>("credito")).ToString();
                    var pend= dt.AsEnumerable().Sum(x => x.Field<decimal?>("pendente")).ToString();
                    f.tbTOTDOCS.Text=deb.SetMask();
                    f.tbTOTPAGO.Text=cre.SetMask();
                    f.tbPENDENTE.Text = pend.SetMask();
                    f.label1.Text = "CONTA CORRENTE DO FORNECEDOR";
                    f.Filtro = $"Fornecedor: {tbNome.tb1.Text}";
                    f.ShowForm(this);
                }
                else
                {
                    MsBox.Show("O Cliente não tem movimentos");
                }
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!..");
            }
        }
        public void BindFnc(Cl cl)
        {
            var max = SQL.VMax("no", "fnc");
            _fnc.Fncstamp = Pbl.Stamp();
            _fnc.Nome = cl.Nome;
            _fnc.Moeda = cl.Moeda;
            _fnc.Ccusto = cl.Ccusto;
            _fnc.Morada = cl.Morada;
            _fnc.Email = cl.Email;
            _fnc.Data = cl.Datacl;
            _fnc.Celular = cl.Celular;
            _fnc.Prontopag = cl.Prontopag;
            _fnc.Imagem = cl.Imagem;
            _fnc.No = max.ToString();
            _fnc.Obs = cl.Obs;
            _fnc.Pais = cl.Pais;
            _fnc.Status = cl.Status;
            _fnc.Nuit = cl.Nuit;
            _fnc.Localidade = cl.Localidade;
            _fnc.Site = cl.Site;
            _fnc.Fncstamp = cl.Clstamp;
            PreencheCampos(_fnc.ToDataTable(),0);
        }
        private void transformarEmCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var xx = Helper.GetUsrAcessosList("tpgf");
            if (xx.valido)
            {
                var ver = SQL.GetGen2DT($"select * from cl where Clstamp='{CLocalStamp}'");
                if (!ver.HasRows())
                {
                    var fnc = new FrmCl();
                    fnc.Usracessos = xx.lista.FirstOrDefault();
                    fnc.ShowForm(this);
                    fnc.btnNovo.PerformClick();
                    fnc._cl.Provincia = "";
                    fnc._cl.Distrito = "";
                    fnc._cl.Fnc = _fnc.Nome;
                    fnc._cl.Nofnc = _fnc.No;
                    fnc.BindCl(_fnc);
                    fnc._cl.Clstamp = CLocalStamp;
                    fnc.CLocalStamp = CLocalStamp;
                }
                else
                {
                    MsBox.Show("Este Fornecedor já é cliente!..");
                }

            }
        }

        private bool gridPanel22_BeforeAddLineEvent()
        {
            CriarContasContabilidade();
            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CLocalStamp)) return;
            var dt = SQL.GetDT("fnc", "*", $"fncstamp='{CLocalStamp.Trim()}'", null);  
            PreencheCampos(dt,0);
        }

        private void listagemDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmGenreport
            {
                Gendt = SQL.GetGen2DT("Select no,nome,Celular from fnc"), Titulo = "Listagem de Fornecedores"
            };
            f.ShowForm(this);
        }

        private void btnCriaContasCT_Click(object sender, EventArgs e)
        {

        }

        private void ExtratodeCompras_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                var f = new FrmCc
                {
                    txtNome = {Text = tbNome.tb1.Text},
                    txtNumero = {Text = tbNumero.tb1.Text},
                    label1 = {Text = @"Extrato de vendas e regularizações"},
                    Cl = false,
                    Tipo = "Fornecedor"
                };
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar o Fornecedor!..");
            }
        }
        public string Conta { get; set; }
        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                Conta =Integracao.GetContaNaContabilidade(tbNome.tb1.Text,"421");
                if (!string.IsNullOrEmpty(Conta))
                {
                    if (!SQL.CheckExist($"select conta from fncct where conta ='{Conta}'"))
                    {
                        gridPanel22.btnNovo.PerformClick();
                        if (gridContasCT.CurrentRow !=null)
                        {
                            gridContasCT.DataRowr["conta"]=Conta;
                            gridContasCT.DataRowr["Descgrupo"]="FORNECEDORES C/C";
                            gridContasCT.DataRowr["Contacc"]=true;
                            gridContasCT.Update();
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial()+$"O Fornecedor: {tbNome.tb1.Text}, já tem conta criada!");
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+$"O Fornecedor: {tbNome.tb1.Text}, não tem conta por sincronizar!");
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                tbNome.tb1.Text= tbNome.tb1.Text.ToUpper();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                tbNome.tb1.Text= tbNome.tb1.Text.ToLower();
            }
        }
        public string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                tbNome.tb1.Text= ToTitleCase(tbNome.tb1.Text);
            }
        }
        public DataRow DataRow { get; set; }
        public DataTable DtSt { get; private set; }
        private void gridUi2_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi2.CurrentRow == null) return;
            if (string.IsNullOrEmpty(tbNome.tb1.Text)) return;
            var name = gridUi2.CurrentCell.OwningColumn.Name.ToLower();
            DataRow = gridUi2.CurrentRow.ToDataRow();
            if (name.Equals("grau"))
            {
                gridUi2.CurrentCell.Value = gridUi2.CurrentCell.Value.ToString().ToUpper();
                //Muito Importante, Importante,pouco importante,irrelevante
                var qry = "select upper(Descricao) Descricao,Auxiliarstamp from Auxiliar where Tabela=69 ORDER BY Codigo";
                DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (name.Equals("avaliacao"))
            {
                gridUi2.CurrentCell.Value = gridUi2.CurrentCell.Value.ToString().ToUpper();
                //Excelente,óptimo,bom,regular, ruim, horrível
                var qry = "select upper(Descricao) Descricao,Auxiliarstamp from Auxiliar where Tabela=72 ORDER BY Codigo";
                DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else
            {
                DtSt = null;
                var autoText = e.Control as TextBox;
                if (autoText != null) autoText.AutoCompleteCustomSource = null;
            }
        }
        private void gridUi2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nomer = gridUi2.CurrentCell.OwningColumn.Name.ToLower();
            if (nomer.Equals("avaliacao"))
            {
                SetFaccl("Descricao");
            }
        }
        private void SetFaccl(string campo)
        {
            try
            {
                if (gridUi2.CurrentCell?.Value == null) return;
                var valor = gridUi2.CurrentCell.Value.ToString().Trim();
                if (DtSt == null) return;
                if (!string.IsNullOrEmpty(valor))
                {
                    DataRow dr;
                    dr = DtSt.AsEnumerable().FirstOrDefault(s =>
                        s.Field<string>(campo).Trim().ToLower().Equals(valor.ToLower()));

                    if (dr != null)
                    {
                        Addline(dr["Auxiliarstamp"].ToString().Trim());
                    }
                }
            }
            catch
            {//
            }

        }
        public override void Addline(string referenc)
        {
            #region Auxiliar
            try
            {
                var tmpFound = SQL.GetRowToEnt<Auxiliar>($"Auxiliarstamp='{referenc.Trim().ToLower()}'"); //EF.GetEnt<Auxiliar>(p => p.Auxiliarstamp.Trim().ToLower().Equals($"{referenc.Trim().ToLower()}"));
                if (gridUi2.CurrentRow != null)
                    gridUi2.CurrentRow.Cells["grau"].Value = tmpFound.Obs;
            }
            catch
            {
                //
            }
            #endregion
        }

        private void importarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("fnc", "", "", "Fornecedores");
        }

        private void actualizarOStampDoClieneteNaContaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja actualizar o stamp do fornecedor na conta corrente!", DResult.YesNo);
            if (dr.DialogResult == DialogResult.Yes)
            {
                try
                {
                    SQL.SqlCmd("Update fcc set fncstamp =(select fncstamp from fnc where no =fcc.no) where fcc.fncstamp =''");
                    MsBox.Show("Processo executado com sucesso");
                }
                catch (Exception ex)
                {
                    MsBox.Show(ex.Message);
                }

            }
        }
    }
}
