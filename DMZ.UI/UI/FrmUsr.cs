using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmUsr : FrmClasse
    {
        private Usr _usr;
        public DataTable DtUsracessos;
        public FrmUsr()
        {
            InitializeComponent();
        }

        private void FrmUsr_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "usr";
            DtUsracessos= SQL.Initialize("Usracessos");
        }
        public override void DefaultValues()
        {
            _usr = DoAddline<Usr>();
            tbPw.tb1.Enabled = true;
            status.SetStatusValue();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_usr);
            //_usr.Pw = Criptografia.Encrypt(_usr.Pw);
            EF.Save(_usr);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _usr = FillControls(_usr, dt, i);
            //_usr.Pw = Criptografia.Decrypt(_usr.Pw);
            tbPw.tb1.Text = _usr.Pw;
            tbPw.tb1.Enabled = false;
            DtUsracessos = SQL.GetDT("Usracessos", $"Usrstamp ='{CLocalStamp.Trim()}'");

        }
        public override void AfterSave()
        {
            tbPw.tb1.ReadOnly = false;
            SQL.Save(DtUsracessos, "Usracessos", false, CLocalStamp, "usr");
            if (_usr.Usrstamp.Equals(Pbl.Usr.Usrstamp.Trim()))
            {
                Pbl.Usr = _usr;
                Pbl.Usracessos = DtUsracessos.DtToList<Usracessos>();
            }
        }

        private DataTable _dtmod;
        private DataTable dtContas;

        private void gridUi1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
            const string qry = "select  sigla,descricao from Empresamod";
            var name = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
           // var DataRow = ((DataRowView)gridUi1.CurrentRow.DataBoundItem).Row;
            
            if (name.Equals("descricao"))
            {
                _dtmod=Helper.SetBinds(e.Control, "descricao",qry);
            }
        }

        private void gridUi1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                SetVAlue("descricao");
            }
        }
        private void SetVAlue(string referenc)
        {
            if (gridUi1.CurrentCell?.Value == null) return;
            var valor = gridUi1.CurrentCell.Value.ToString().Trim();
            var dr = _dtmod.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().Equals(valor));
            if (dr == null) return;
            //var quant=SQL.GetValue("Count(codigo) as quant","UsrModulo",$"Codigo='{dr[0].ToString().Trim()}'").ToDecimal();
            //bool procede=true;
            //switch (dr[0].ToString().Trim())
            //{           
            //    case "GES":
            //        if (quant>Pbl.UGes)
            //        {
            //            MsBox.Show(Messagem.ParteInicial()+$"Já atingiu o limite de usuários para o módulo:{dr[1].ToString().Trim()} ");
            //            procede=false;
            //        }
            //    break;
            //    case "CT":
            //        if (quant>Pbl.UCt)
            //        {
            //            MsBox.Show(Messagem.ParteInicial()+$"Já atingiu o limite de usuários para o módulo:{dr[1].ToString().Trim()} ");
            //            procede=false;
            //        }
            //    break;
            //    case "RHS":
            //        if (quant>Pbl.URh)
            //        {
            //            MsBox.Show(Messagem.ParteInicial()+$"Já atingiu o limite de usuários para o módulo:{dr[1].ToString().Trim()} ");
            //            procede=false;
            //        }
            //    break;

            //}
            //if (procede)
            //{
            //    switch (referenc)
            //    {
            //        case "descricao":
            //            if (gridUi1.CurrentRow != null) 
            //                gridUi1.CurrentRow.Cells["codigo"].Value = dr[0].ToString();
            //            break;
            //        default:
            //            if (gridUi1.CurrentRow != null) 
            //                gridUi1.CurrentRow.Cells["descricao"].Value = dr[1].ToString();
            //            break;
            //    }
            //}
            //else
            //{
            //    var r = gridUi1.CurrentRow?.DataBoundItem as DataRow;
            //    if (r != null && r.RowState==DataRowState.Added)
            //    {
            //        gridUi1.Rows.RemoveAt(gridUi1.CurrentRow.Index);
            //    }
            //}

            switch (referenc)
            {
                case "descricao":
                    if (gridUi1.CurrentRow != null)
                        gridUi1.CurrentRow.Cells["codigo"].Value = dr[0].ToString();
                    break;
                default:
                    if (gridUi1.CurrentRow != null)
                        gridUi1.CurrentRow.Cells["descricao"].Value = dr[1].ToString();
                    break;
            }
            gridUi1.Update();
        }

        private void caixa_RefreshControls()
        {
            tbSigla.tb1.Text = SQL.GetField("sigla", "contas", $"Codigo={caixa.Text2}").ToString();
        }

        private void procura2_RefreshControls()
        {

            if (procura2.Text2.ToDecimal().Equals(1))
            {
                _usr.Usradmin = true;
                cbAdminn.Update(true);
            }
            else
            {
                _usr.Usradmin = false;
                cbAdminn.Update(false);
            }
        }

        private void cbAdmin_Load(object sender, EventArgs e)
        {

        }

        private void procura8_RefreshControls()
        {
            caixa.Condicao = $" ccu.Ccustamp ='{tbCcusto.Text3.Trim()}'";
            Armazem.Condicao = $" ccu.Ccustamp ='{tbCcusto.Text3.Trim()}'";
        }

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridUi1.CurrentCell.OwningColumn.Name.Equals("acessos")) return;
            if (gridUi1.CurrentRow == null) return;
            if (gridUi1.CurrentRow.Cells["codigo"].Value.ToString().Trim().ToLower().Equals("ges"))
            {
                DtUsracessos = SQL.GetDT("Usracessos", $"Usrstamp ='{CLocalStamp}' ");
                var dr = gridUi1.CurrentRow.ToDataRow();
                if (!dr.DataRowIsNull())
                {
                    var mod = dr.DrToEntity<UsrModulo>();
                    var a = new FrmAcessos(this);
                    //a.DtAcessos = SQL.Initialize();
                    a.label1.Text = gridUi1.CurrentRow.Cells["descricao"].Value.ToString();
                    a.lblUser.Text = tbDefault1.tb1.Text;
                   // a.gridUi1.DataSource = null;
                    //a.gridUi1.AutoGenerateColumns = false;
                    a.Usrmodulostamp = mod.Usrmodulostamp;
                    a.Usrstamp = CLocalStamp;
                    a.DtAcessos = DtUsracessos;
                    //a.gridUi1.DataSource = DtUsracessos;
                    a.ShowForm(this);
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "Deve selecionar o modulo que pretende atribuir acessos!");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Apenas o módulo GESTÃO, tem acessos configurados!");
               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                if (_usr !=null && Pbl.Usr != null)
                {
                    if (_usr.Usrstamp.Equals(Pbl.Usr.Usrstamp.Trim()))
                    {
                        var dt = SQL.GetDT("Usracessos", $"Usrstamp ='{CLocalStamp}'");
                        Pbl.Usracessos=dt.DtToList<Usracessos>();   
                    }
                }
            Close();
        }

        private void tbImpressoraNormal_GetDataEvent()
        {
            tbImpressoraNormal.SqlDt =ReportHelper.PrinterList(); 
        }

        private void procura4_GetDataEvent()
        {
            procura4.SqlDt =ReportHelper.PrinterList(); 
        }

        private void gridUiConta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUiConta.CurrentRow == null) return;
            if (!tbCcusto.Text3.IsNullOrEmpty())
            {
                string qry = $"select Codtz,Descricao,Contasstamp,Descpos,cx from ccu_caixa where Ccustamp ='{tbCcusto.Text3.Trim()}'";
                var name = gridUiConta.CurrentCell.OwningColumn.Name.ToLower();
                if (name.Equals("conta"))
                {
                    dtContas = Helper.SetBinds(e.Control, "descricao", qry);
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"Deve indicar o Centro de custo");
            }
        }

        private void gridUiConta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUiConta.CurrentRow == null) return;
            var lista = new List<Parametros>
            {
                new Parametros {Param1 = "Codtz", Param2 = "Codtz"},
                new Parametros {Param1 = "Contasstamp", Param2 = "Contasstamp"},//Descpos
                new Parametros {Param1 = "Descpos", Param2 = "Descpos"},//cx
                new Parametros {Param1 = "cx", Param2 = "cx"},//cx
            };
            Helper.GridCellEndEdit(gridUiConta, dtContas, lista, "Descricao");
        }

        private void caixa_CondicaProcura()
        {
            //caixa.Condicao = $" ccu.Ccustamp ='{tbCcusto.Text3.Trim()}'";
            if (tbCcusto.Text3.IsNullOrEmpty())
            {
                MsBox.Show("Deve indicar centro de custo primeiro!");
                caixa.Condicao = "";
            }
            else
            {
                caixa.Condicao = $" ccu.Ccustamp ='{tbCcusto.Text3.Trim()}'";
            }
        }

        private void Armazem_CondicaProcura()
        {
            if (tbCcusto.Text3.IsNullOrEmpty())
            {
                MsBox.Show("Deve indicar centro de custo primeiro!");
                Armazem.Condicao = "";
            }
            else
            {
                Armazem.Condicao = $" ccu.Ccustamp ='{tbCcusto.Text3.Trim()}'";
            }
        }

        private void cbDefault32_Load(object sender, EventArgs e)
        {

        }
    }
}
