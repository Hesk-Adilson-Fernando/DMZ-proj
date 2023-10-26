using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI.PRC
{
    public partial class FrmFnc1 : Basic.FrmClasse
    {
        public FrmFnc1()
        {
            InitializeComponent();
        }
        private Fnc _fnc;
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
            status.SetStatusValue();
            CriarContasContabilidade(); 
            using (var dt = SQL.GetGen2DT("select upper(Descricao) Descricao from Auxiliar where Tabela=71 ORDER BY Codigo"))
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

        public override void PreencheCampos(DataTable dtt, int ii)
        {
            _fnc = FillControls(_fnc, dtt, ii);
            if (gridUi2.Rows.Count == 0)
            {
                var dt = SQL.GetGen2DT("select upper(Descricao) Descricao from Auxiliar where Tabela=71 ORDER BY Codigo");

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
            AbrirCC();

            //if (!string.IsNullOrEmpty(tbNome.tB1.Text))
            //{
            //    var f = new FrmCc
            //    {
            //        txtNome = { Text = tbNome.tB1.Text },
            //        txtNumero = { Text = tbNumero.tB1.Text },
            //        label1 = { Text = $"Conta Corrente de: {tbNome.tB1.Text}" },
            //        Tabela = "fcc"
            //    };
            //    f.ShowForm(this);
            //}
            //else
            //{
            //    MsBox.Show("Deve indicar o fornecedor!..");
            //}
        }
        private void AbrirCC()
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                var dt = new DataTable(); //EntBl.GetExtrato(tbNumero.tB1.Text,false);
                if (dt?.Rows.Count>0)
                {
                    //var f = new FrmCcCl { Tabela = dt,txtNome = { Text = tbNome.tB1.Text },txtNumero = { Text = tbNumero.tB1.Text }};
                    //var deb= dt.AsEnumerable().Sum(x => x.Field<decimal?>("debito")).ToString();
                    //var cre= dt.AsEnumerable().Sum(x => x.Field<decimal?>("credito")).ToString();
                    //var pend= dt.AsEnumerable().Sum(x => x.Field<decimal?>("pendente")).ToString();
                    //f.tbTOTDOCS.Text=deb.SetMask();
                    //f.tbTOTPAGO.Text=cre.SetMask();
                    //f.tbPENDENTE.Text = pend.SetMask();
                    //f.label1.Text = "CONTA CORRENTE DO FORNECEDOR";
                    //f.Filtro = $"Fornecedor: {tbNome.tB1.Text}";
                    //f.ShowForm(this);
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
            PreencheCampos(_fnc.ToDataTable(),0);
        }

        private void transformarEmCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fnc = new FrmCl();
            fnc.ShowForm(this);
            fnc.btnNovo.PerformClick();
            fnc.BindCl(_fnc);
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
                //Muito Importante, Importante,pouco importante,irrelevante
                var qry = "select upper(Descricao) Descricao,Auxiliarstamp from Auxiliar where Tabela=69 ORDER BY Codigo";
                DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (name.Equals("avaliacao"))
            {
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
                        s.Field<string>(campo).Trim().Equals(valor));

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
                var tmpFound = SQL.GetRowToEnt<Auxiliar>($"Auxiliarstamp ='{referenc.Trim()}'");//EF.GetEnt<Auxiliar>(p => p.Auxiliarstamp.Trim().Equals($"{referenc.Trim()}"));

                if (gridUi2.CurrentRow != null)
                    gridUi2.CurrentRow.Cells["grau"].Value = tmpFound.Obs;
            }
            catch
            {
                //
            }
            #endregion
        }
    }
}
