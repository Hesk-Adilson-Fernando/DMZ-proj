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
using DMZ.UI.UI.RH;
using DMZ.UI.UI.TM;

namespace DMZ.UI.UI.FT
{
    public partial class FrmVt : FrmClasse
    {
        public FrmVt()
        {
            InitializeComponent();
        }

        private St _st;
        private DataTable dtPe;

        public DataTable DtFnc { get; set; }
        public DataTable DtArm { get; set; }
        public bool Servico { get; set; }
        public DataTable DtSt { get; set; }
        public DataRow DataRow { get; set; }
        public string Origem { get; set; }
        public string Codigo { get; set; }
 

        private void FrmProduto_Load(object sender, EventArgs e)
        {
           // tbMatricula.label1.Text = tbMatricula.Label1Text2;
            tbDescricao.ToUpperCase = true;
            tbReferenc.ToUpperCase = true;
            //tbMatricula.IsMatricula = true;
            Campo1 = "matricula";
            Campo2 = "descricao";
            Ctabela = "st";
            switch (Origem)
            {
                case "Vt":
                    label1.Text = @"Cadastro de Viaturas";
                    CCondicao = "Viatura=1";
                    btnMenuLateral.Visible = true;
                    tbTrailler.label1.Text = @"Trailer";
                    tbTrailler.Condicao = "Trailer =1";
                    Campo2Capition = "Nome da viatura";
                    Codigo = "VT";
                    break;
                case "Tr":
                    label1.Text = @"Cadastro de Trailers";
                    btnMenuLateral.Visible = false;
                    CCondicao = "Trailer=1";
                    tbTrailler.label1.Text = @"Viatura";
                    tbTrailler.Condicao = "Viatura=1";
                    Campo2Capition = "Nome da Trailer";
                    Codigo = "TR";
                    break;
            }
        }
        public override void DefaultValues()
        {
            _st = DoAddline<St>();
            var para = Pbl.Param;
            if (para != null)
            {
                if (para.Prodenum)
                {
                    var xx = $@"Select Max(convert(int,dbo.UDF_ExtractNumbers(referenc)))+1 as maxvalue  from st";
                    //var xx = $@" select isnull(max(isnull(TRY_PARSE(right(ltrim(rtrim(Referenc)),{para.CodprodMascra.Length - 1})AS INT),0)),0)+1 as maxvalue from st where {CCondicao}";
                    var dt = SQL.GetGenDT(xx);
                    if (dt?.Rows.Count > 0)
                    {
                        tbReferenc.tb1.Text = Helper.GetValueByMascara(Codigo, para.CodprodMascra, dt);
                    }
                }
            }
            switch (Origem)
            {
                case "Vt":
                    _st.Trailer = false;
                    _st.Viatura = true;
                    break;
                case "Tr":
                    _st.Trailer = true;
                    _st.Viatura = false;
                    break;
            }
            status.SetStatusValue();
            var tabUnid = SQL.GetGen2DT("select codigo,descricao from Auxiliar where Tabela=6 and Padrao=1 ");
            if (tabUnid?.Rows.Count > 0)
            {
                _st.Unidade = tabUnid.Rows[0]["descricao"].ToString();
            }
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_st);
            EF.Save(_st);
        }


        public override void PreencheCampos(DataTable dt, int i)
        {
            _st = FillControls(_st, dt, i);
        }
        private void gridUI1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUI1.CurrentRow == null) return;
            var nome = gridUI1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                DtSt = Helper.SetBinds(e.Control, "Descricao", "select Ststamp,Referenc,Descricao from st ");
            }
            else if (nome.Equals("referenc"))
            {
                DtSt = Helper.SetBinds(e.Control, "Referenc", "select Ststamp,Referenc,Descricao from st ");
            }
            else
            {
                DtSt = null;
                var autoText = e.Control as TextBox;
                autoText.AutoCompleteCustomSource = null;
            }
        }
        private void gridUI1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUI1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
                SetStcp("descricao");
            if (nome.Equals("referenc"))
                SetStcp("Referenc");
        }
        private void SetStcp(string campo)
        {
            var valor = gridUI1.CurrentCell.Value.ToString().Trim();
            if (DtSt == null) return;
            var dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr != null)
                Addline(dr["Ststamp"].ToString().Trim());
        }
        private void SetStlValues(St st)
        {
            gridUI1.DataRowr["Quantcp"] = 1;
            gridUI1.DataRowr["Descricao"] = st.Descricao.Trim();
            gridUI1.DataRowr["Refcp"] = st.Referenc.Trim();
            gridUI1.DataRowr["refst"] = tbReferenc.tb1.Text;
            gridUI1.DataRowr["Precocp"] = 0;
            gridUI1.DataRowr["Servico"] = Servico;
        }
        public override void Addline(string referenc)
        {
            var tmpFound = SQL.GetRowToEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
            SetStlValues(tmpFound);
            gridUI1.Update();
        }

        private void extratoDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbReferenc.tb1.Text))
            {
                var f = new FrmExtprod { Ststamp = _st.Referenc, txtDescricao = { Text = _st.Descricao } };
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar  um produto que pretender ver o extrato!");
            }
        }
        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnMenuLateral);
        }

        private void gridUI1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gridUi2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi2.CurrentRow == null) return;
            var qry = "select Descricao from Auxiliar where tabela=17";
            var name = gridUi2.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("tipodoc"))
            {
                Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (name.Equals("entidade"))
            {
                qry = "select Descricao from Auxiliar where tabela in('15','16','18')";
                Helper.SetBinds(e.Control, "Descricao", qry);
            }
        }
        private void gridUi2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gridUi4_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi4.CurrentRow == null) return;
            var qry = "select Auxiliarstamp,Codigo,Descricao from Auxiliar ";
            var name = gridUi4.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("Tipodoc"))
            {
                DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            if (name.Equals("Entidade"))
            {
                qry = "select Entstamp,Nome from Ent";
                DtSt = Helper.SetBinds(e.Control, "Nome", qry);
            }
        }

        private void importarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ipor = new DataImport
            {
                TopLevel = true,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen
            };
            ipor.Enviadados += RecebeDados;
            ipor.ShowDialog();
        }

        private void RecebeDados(DataRow dr)
        {
            BeginInvoke((Action)delegate
           {
               ClearDataGridView();
               EstadoDaTela(AccaoNaTela.Inserir);
               Familia.tb1.Text = dr["Familia"].ToString();
               Familia.Text2 = GetCodFam(Familia.tb1.Text) ?? "";
               tbDescricao.tb1.Text = dr["Descricao"].ToString();
               tbReferenc.tb1.Text = dr["Referenc"].ToString();
               _st.Obs = dr["Obs"].ToString();
               var tabiva = SQL.GetGen2DT("select Codigo,Descricao from Auxiliar where Tabela=5 and Padrao=1");
               if (tabiva?.Rows.Count > 0)
               {
                   _st.Tabiva = tabiva.Rows[0]["codigo"].ToDecimal();
                   _st.Txiva = tabiva.Rows[0]["Descricao"].ToDecimal();
               }
               GravaProduto();
           });

        }

        private void GravaProduto()
        {
            var lista = Helper.CamposObrigatorios(this);
            if (GravarNovo)
            {

                if (lista.Count == 0)
                {
                    if (BeforeSave())
                    {
                        Save();
                        OnGravaFilhas();
                        AfterSave();
                        Procurou = true;
                        //progressBar1.Value = 0;
                        lblMessage.Text = @"Gravado com sucesso";
                        //timer1.Start();
                    }
                    else
                    {
                        Cancelado = true;
                    }
                }
                else
                {
                    Helper.CheckRequered(lista);
                }
            }
            if (Actualizando)
            {
                if (lista.Count == 0)
                {
                    Save();
                    OnGravaFilhas();
                    AfterSave();
                    Lista = new List<string>();
                }
                else
                {
                    Helper.CheckRequered(lista);
                }
            }

            if (!Cancelado)
            {
                EstadoDaTela(AccaoNaTela.Padrao);
                HabilitaCampo();
            }
            Cancelado = false;
        }

        private string GetCodFam(string tb1Text)
        {
            var retorno = "";
            var dt = SQL.GetGen2DT($"select codigo from Familia where descricao='{tb1Text.Trim()}' ");
            if (dt?.Rows.Count > 0)
            {
                retorno = dt.Rows[0][0].ToString();
            }
            return retorno;
        }
        private void tabPageManutencao_Click(object sender, EventArgs e)
        {

        }


        private void gridUi4_CancelRowEdit(object sender, QuestionEventArgs e)
        {

        }

        private void gridUi4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


        }

        private bool gridPanel26_BeforeAddLineEvent()
        {

            if (tbDefault14.tb1.Text.ToDecimal() == 0 || tbDefault14.tb1.Text.ToDecimal() == 0)
            {
                MsBox.Show("Preencha o campo Nᵒ de Manutenções com valor superior a 0");
            }
            else
            {
                var linhas = tbDefault14.tb1.Text.ToInt();
                const decimal km = 0;
                decimal periodo = 0;
                if (gridUi4.Rows.Count>0)
                {
                    var row = gridUi4.Rows[gridUi4.Rows.Count - 1];
                    var numero = row.Cells["Matricula"].Value.ToString().Substring(11, 2).ToInt32();
                    var kmin = row.Cells["Kilometragem"].Value;
                    if (tbKmInicial.tb1.Text.ToDecimal()<kmin.ToDecimal())
                    {
                        MsBox.Show($"A Kilometragem não pode ser inferior que {kmin}");
                    }
                    else
                    {
                        DoIteration(numero,km,linhas,periodo);      
                    }
                }
                else
                {
                    DoIteration(0,km,linhas,periodo);      
                }
            }
            return true;
        }

        private void DoIteration(decimal numero,decimal km,int linhas,decimal periodo)
        {
            for (var i = 1; i <= linhas; i++)
            {
                gridUi4.AddLine();
                
                periodo = tbDefault17.tb1.Text.ToDecimal();
                if (i==1)
                {
                    km = periodo+tbKmInicial.tb1.Text.ToDecimal();
                }
                else
                {
                    km += periodo;
                }
                if (gridUi4.CurrentRow == null) continue;
                gridUi4.DataRowr["Matricula"] = "Manutenção " + (i+numero);
                gridUi4.DataRowr["Valparam"] = periodo;
                gridUi4.DataRowr["Valkm"] = km;
            }
        }
        private void procura5_Load(object sender, EventArgs e)
        {

        }

        private void gridUi4_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbMarca_RefreshControls()
        {
            Modelo.Condicao = $" Auxiliar.Codigo ={tbMarca.Text2.Trim()}";
        }

        private void gridUi2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // determine if click was on our date column
            var nome =gridUi2.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("DtTermino") || nome.Equals("Inicio"))
            {
                Helper.AddDateTimePicker(gridUi2, e);
            }
            gridUi2.Anexos();
        }

        private void Familia_RefreshControls()
        {
            subFamilia.Condicao = $" f.descricao =' {Familia.tb1.Text.Trim()}'";
        }

        private void listagemDeViaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmGenreport
            {
                Gendt = SQL.GetGen2DT("Select * from st  where Viatura=1"), Titulo = "Listagem de Viatutas"
            };
            f.ShowForm(this);
        }

        private bool gridPanel21_BeforeAddLineEvent()
        {
            var qry = $"select Pestamp,Nome,tipo from pe";
            dtPe = SQL.GetGen2DT(qry);
            if (dtPe.HasRows())
            {
                var f = new FrmSelect
                {
                    SelectCampos = "",
                    HideFirstColumn = true,
                    Tamanhos = new List<decimal>() { 0, 150, 100 },
                    ColFillName = "Nome",
                    Tabela = "",
                    Condicao = "",
                    SendData = ReceiveInfo,
                    _dt = dtPe
                };
                var xx = $"select Pestamp,Nome,tipo from pe where 1=0";
                f._dt2 = SQL.GetGen2DT(xx);
                f.ShowDialog();
            }
            else
            {
                MsBox.Show("Não foi encontrado nenhum Funcionário, porfavor consulte o RH");
            }
            return true;
        }

        private void ReceiveInfo(DataTable dt)
        {
            if (dt.HasRows())
            {
                foreach (var row in dt.AsEnumerable())
                {
                    if (row != null)
                    {
                        if (!SQL.CheckExist($"select Stpestamp from Stpe where Stpestamp='{row["Pestamp"].ToTrim()}' and ststamp='{CLocalStamp.Trim()}'"))
                        {
                            gridUiPe.AddLine();
                            gridUiPe.DataRowr["Ststamp"] = CLocalStamp;
                            gridUiPe.DataRowr["Stpestamp"] = row["Pestamp"];
                            gridUiPe.DataRowr["Funcao"] = row["tipo"];
                            gridUiPe.DataRowr["Nome"] = row["Nome"];
                        }
                    }
                }
                gridUiPe.Update();
            }
        }

        private bool gridPanel22_BeforeAddLineEvent()
        {
            var qry = $"select Maquinastamp,IMEI,Descricao from Maquina";
            dtPe = SQL.GetGen2DT(qry);
            if (dtPe.HasRows())
            {
                var f = new FrmSelect
                {
                    SelectCampos = "",
                    HideFirstColumn = true,
                    Tamanhos = new List<decimal>() { 0, 100, 150 },
                    ColFillName = "Descricao",
                    Tabela = "",
                    Condicao = "",
                    SendData = ReceiveInfo2,
                    _dt = dtPe
                };
                var xx = $"select Maquinastamp,IMEI,Descricao from Maquina where 1=0";
                f._dt2 = SQL.GetGen2DT(xx);
                f.ShowDialog();
            }
            else
            {
                MsBox.Show("Não foi encontrada nenhuma Maquina POS, porfavor consulte sector técnico");
            }
            return true;
        }

        private void ReceiveInfo2(DataTable dt)
        {
            if (dt.HasRows())
            {
                foreach (var row in dt.AsEnumerable())
                {
                    if (row != null)
                    {
                        if (!SQL.CheckExist($"select Maquinastamp from Stmaq where Maquinastamp='{row["Maquinastamp"].ToTrim()}' and ststamp='{CLocalStamp.Trim()}'"))
                        {
                            gridUiMaq.AddLine();
                            gridUiMaq.DataRowr["Ststamp"] = CLocalStamp;
                            gridUiMaq.DataRowr["Maquinastamp"] = row["Maquinastamp"];
                            gridUiMaq.DataRowr["Descricao"] = row["Descricao"];
                            gridUiMaq.DataRowr["IMEI"] = row["IMEI"];
                        }
                    }
                }
                gridUiMaq.Update();
            }
        }

        private void gridUiPe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.ShowForm<FrmPes>(gridUiPe, this, "pe", "pestamp", "ori");
        }

        private void gridUiMaq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.ShowForm<FrmMaquina>(gridUiPe, this, "Maquina", "Maquinastamp", "ok");
        }
    }
}
    

