using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.Reports.DSTableAdapters;
using Utilities = DMZ.BL.Classes.Utilities;

namespace DMZ.UI.UI.RH
{
    public partial class FrmPerclAutomat : FrmClasse2
    {
        private DataTable SelTable;
        public Tpgp TmpTpgp { get; set; }
        DS ds;
        public FrmPerclAutomat()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        private void FrmPerclAutomat_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Pbl.SqlDate.Year;
            tbCCusto.tb1.Text = Pbl.CCu.Descricao;
            tbCCusto.Text2 = Pbl.CCu.Ccustamp;
            UpdateQuerry();
            dtData.dt1.Value=Pbl.SqlDate;
            QryPeRcl= SQL.Initialize("percl");
            EditMode=true;
            cbDataProc.Update(true);
            SelTable = new DataTable();
            SelTable.Columns.Add(new DataColumn("Valor", typeof(decimal)));
            SelTable.Columns.Add(new DataColumn("Rindex", typeof(int)));
            SelTable.PrimaryKey = new[] { SelTable.Columns["Rindex"]};
            TmpTpgp =SQL.GetRowToEnt<Tpgp>(" defa=1 ");
        }

        private void BindGrid()
        {
            var condicao = "";
            if (!dmzProcess.tb1.Text.IsNullOrEmpty())
            {
                condicao = $" and oristamp='{dmzProcess.Text2.Trim()}'";
            }
            var str = $@"Select no,nome,descricao,nrdoc,data,valordoc,valorpreg,valorreg,ok,Peccstamp,origem,oristamp,moeda,banco='',Contatesoura='',titulo='',Contasstamp='',codtz=cast(0 as decimal),Pestamp  from (
			Select documento as descricao,pecc.nrdoc,data = convert(char(12), pecc.data, 103),
			valordoc = (Case when pecc.origem in ('RD') then abs((Case when moeda = 'MZN' then credito else creditom end))*-1
			else (Case when moeda = 'MZN' then debito else debitom end) end),
			valorpreg = ((Case when pecc.origem in ('RD') then abs((Case when moeda = 'MZN' then credito else creditom end))*-1
			else (Case when moeda = 'MZN' then debito else debitom end) end))-sum(isnull((Case when moeda = 'MZN' then iif(percll.anulado=1,0,percll.valorreg) else iif(percll.anulado=1,0,percll.mvalorreg) end), 0)),		
			valorreg = ((Case when pecc.origem in ('RD') then abs((Case when moeda = 'MZN' then credito else creditom end))*-1
			else (Case when moeda = 'MZN' then debito else debitom end) end))-sum(isnull((Case when moeda = 'MZN' then iif(percll.anulado=1,0,percll.valorreg) else iif(percll.anulado=1,0,percll.mvalorreg) end), 0)),
			ok=cast(0 as bit),pecc.Peccstamp,pecc.origem,oristamp,debito,credito,nome,no,moeda,Pestamp
			from pecc left join percll on pecc.Peccstamp = percll.Pccstamp where pecc.origem in ('PERCL', 'PRC')
			group by nome,no,Pestamp,documento,pecc.nrdoc,pecc.data,pecc.Peccstamp,pecc.data,pecc.credito,pecc.debito,pecc.creditom,pecc.debitom,pecc.moeda,pecc.origem,oristamp
				)tmp1 where valorpreg <> 0 and debito-credito<>0 {condicao} order by data,Nome";            
            QryPecc = SQL.GetGen2DT(str);
            if (!QryPecc.HasRows()) return;
            tbTotalregisto.Invokex(k=>k.Text=QryPecc.Rows.Count.ToString().SetMask());
            tbTotalValor.Invokex(k=>k.Text= QryPecc.AsEnumerable().Sum(x=>x.Field<decimal>("valorpreg")).ToString().SetMask());
            GridProcess.Invokex(x=>x.DataSource=null);
            GridProcess.Invokex(x=>x.AutoGenerateColumns=false);
            GridProcess.Invokex(x=>x.DataSource = QryPecc);
            UpdateGrid("Formap",tbFormas.tb1.Text);
            UpdateGrid("banco",tbConta.Text4);
            tbConta_RefreshControls();
            tbContador.Invokex(x=>x.Text="");
            tbValorReg.Invokex(x=>x.Text="");
        }

        public DataTable QryPecc { get; set; }
        public DataTable QryPeRcl { get; set; }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void RecebeDados(DataRow r,bool fim)
        { 
            var perc = QryPeRcl.NewRow().Inicialize();//Utilities.DoAddline<Percl>();
            FillPercl(perc,r);
            //QryPeRcl.Rows.Add(perc);
            var dt=GetValue(r,perc);
            var dt2=CreateFormasP(r,perc);
            var ent =perc.DrToEntity<Percl>();
            EF.Save(ent);
            SQL.Save(dt, "Percll", true, ent.Perclstamp, "Percl");
            SQL.Save(dt2, "Formasp", true, ent.Perclstamp, "Percl");
            if (fim)
            {
                //gridUi1.Invokex(x=>x.DataSource=null);
                //gridUi1.Invokex(x=>x.AutoGenerateColumns=false);
                //gridUi1.Invokex(x=>x.DataSource = QryPeRcl);
                BindGrid();
                BindGridRcl2(r["oristamp"].ToString());
                Alert("Recibo(s) processado(s) com sucesso!", Form_Alert.EnmType.Success);
            }
        }
        private void btnAddprocess_Click(object sender, EventArgs e)
        {
            GridProcess.Update();
            var dr = MsBox.Show(Messagem.ParteInicial()+"Deseja que o Software emite recibos de funcionários?",DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            if (!Valido()) return;
            if (QryPecc.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
            {
                QryPecc = QryPecc.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                if (CheckSaldo(QryPecc))
                {
                    Helper.DoProgressProcess(QryPecc, RecebeDados);
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"Porfavor deve selecionar a(s) linha(s) que pretende processar!");
            }
        }

        private bool CheckSaldo(DataTable dt)
        {
            var total = tbValorReg.Text.ToDecimal();
            var saldo = SQL.GetValue("saldo","contas",$"Contasstamp='{tbConta.Text2.ToString().Trim()}'").ToDecimal();
            var naoMovNeg= SQL.GetValue("Noneg", "contas", $"Contasstamp='{tbConta.Text2.ToString().Trim()}'").ToBool();
            if (saldo > total)
            {
                return true;
            }
            else
            {
                var dr=MsBox.Show($"O saldo da  {tbConta.tb1.Text} é insuficiente \r\n\r\nO disponível existente é: {saldo.ToMask()}\r\n\r\nO necessário para os recibos é: {total.ToMask()} \r\n\r\nDeseja continuar com emissão de recibo(s)?",DResult.YesNo);
                if (dr.DialogResult == DialogResult.Yes)
                {
                    if (naoMovNeg)
                    {
                        MsBox.Show($"A {tbConta.tb1.Text} não pode ter saldos negativos?");
                        return false;
                    }
                    else
                    {
                        return true;
                    }                   
                }
                else
                {
                    return false;
                }                
            }
        }

        private bool Valido()
        {
            var ret = false;
            if (QryPecc?.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(tbFormas.tb1.Text))
                {
                    if (!string.IsNullOrEmpty(tbConta.tb1.Text))
                    {
                        ret = true;
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Deve indicar a conta de pagamento!");    
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "Deve indicar a forma de pagamento!");    
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não temos conta corrente para emissão de recibos!");
            }

            return ret;
        }

        private DataTable CreateFormasP(DataRow dr,DataRow p)
        {
            var f = Utilities.DoAddline<Formasp>();
            f.Perclstamp = p["Perclstamp"].ToString();
            f.Codmovtz = p["Codmovtz"].ToDecimal();
            f.Descmovtz = p["Descmovtz"].ToString();
            f.Codtz = dr["Codtz"].ToDecimal();//tbConta.Text3.ToDecimal();
            f.Contatesoura = dr["Contatesoura"].ToString();
            f.Contasstamp = dr["Contasstamp"].ToString();
            f.Valor = dr["valorreg"].ToDecimal();
            f.Titulo =dr["titulo"].ToString();
            f.Banco = dr["banco"].ToString();
            f.Origem = "PERCL";
            f.Dcheque = dtData.dt1.Value;
            return f.ToDataTable();
        }
        private void FillPercl(DataRow p,DataRow dr)
        {
            p["Codmovtz"] = TmpTpgp.Codmovtz;
            p["Descmovtz"]  = TmpTpgp.Descmovtz;
            p["Codmovcc"]  = TmpTpgp.Codmovcc;
            p["Descmovcc"]  = TmpTpgp.Descmovcc;
            p["No"]  = dr["no"].ToString();
            p["Nome"] = dr["nome"].ToString();
            p["Numdoc"]  = TmpTpgp.Numdoc;
            p["Nomedoc"]  = TmpTpgp.Descricao;
            p["Sigla"]  = TmpTpgp.Sigla;
            p["Moeda"]  = dr["moeda"].ToString();
            p["Total"] = p["Total"].ToDecimal() + dr["valorreg"].ToDecimal();
            p["Data"]  =cbDataProc.cb1.Checked? dr["data"]: dtData.dt1.Value;
            p["Processtamp"] = dr["oristamp"].ToString();
            p["Ccusto"]  = tbCCusto.tb1.Text;
            p["Nomecomerc"]= dr["descricao"];
            p["Obs"]  = tbObs.Text;
            p["Numdoc"] = TmpTpgp.Numdoc;
            p["Nomedoc"] = TmpTpgp.Descricao;
            p["Codmovcc"] = TmpTpgp.Codmovcc;
            p["Descmovcc"] = TmpTpgp.Descmovcc;
            p["Codmovtz"] = TmpTpgp.Codmovtz;
            p["Descmovtz"] = TmpTpgp.Descmovtz;
            p["Sigla"] = TmpTpgp.Sigla; //Pestamp
            p["Pestamp"] =dr["Pestamp"];
            p["Usrstamp"] = Pbl.Usr.Usrstamp;
            var x = SQL.Maximo("Percl", "numero", $"Ccusto ='{Pbl.Usr.Ccusto.Trim()}'");
            p["Numero"] =x;
        }

        private DataTable GetValue(DataRow r, DataRow p)
        {
            var dt = SQL.Initialize("Percll");
            var r2 = dt.NewRow().Inicialize();
            r2["descricao"] = r["descricao"];
            r2["valorpreg"] = r["valorpreg"];
            r2["valorreg"] = r["valorreg"];
            r2["data"] = r["data"];
            r2["Pccstamp"] = r["peccstamp"];
            r2["Percllstamp"] = Pbl.Stamp();
            r2["Perclstamp"] = p["Perclstamp"];
            r2["ValorPend"] = r["valorpreg"].ToDecimal()-r["valorreg"].ToDecimal();
            r2["Valordoc"] = r["Valordoc"];
            r2["nrdoc"] = r["nrdoc"];
            dt.Rows.Add(r2);
            return dt;
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false,GridProcess,QryPecc,tbProcura.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmset = new FrmPrintset();
            frmset.DadosEnviados += DadosInfo;
            frmset.ShowPreviewButton = false;
            frmset.ShowForm(this, true);
            //MenuPrint.ShowMenuStrip(button2);
            //DS ds = new DS();
            //var Rcll = dgvRcll.GetBindedTable();
            //var formasp = dgvFormasp2.Grelha.DataSource as DataTable;
            //var ret = Imprimir.FillData(_percl.ToDataTable(), Rcll, formasp, ds.Percl, ds.Formasp);
            //Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgp.Nomfile, "PERCL", this, TmpTpgp.XmlString, true, ds);
            //Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, tbFornec.Text2, TmpTpgp.Nomfile.Trim(), "PERCL", this, Linguas.PT);
        }
        public void DadosInfo(string impressoara,decimal numImpresoes, List<string> lista, string lingua,string tamanhoPapel)
        {
            gridUi1.Update();
            var xmlstring = "";
            var Nomfile = "";
            var dt = gridUi1.GetBindedTable();
            if (dt.HasRows())
            {
                if (dt.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
                {
                    dt = dt.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                    DS ds = new DS();
                    if (tamanhoPapel=="A5")
                    {
                        xmlstring = TmpTpgp.XmlStringa5;
                        Nomfile = TmpTpgp.Nomfile2;
                    }
                    if (tamanhoPapel == "A4")
                    {
                        xmlstring = TmpTpgp.XmlString;
                        Nomfile = TmpTpgp.Nomfile;
                    }
                    var _reportPath =ReportHelper.ReportPath(Nomfile, xmlstring);
                    foreach (var row in dt.AsEnumerable())
                    {
                        var _percl = dt.AsEnumerable().Where(x => x.Field<string>("Perclstamp").Trim().Equals(row["Perclstamp"].ToTrim())).CopyToDataTable();
                        var formasp = SQL.GetGen2DT($"select * from formasp where Perclstamp='{row["Perclstamp"].ToTrim()}'");
                        var Percll = SQL.GetGen2DT($"select * from Percll where Perclstamp='{row["Perclstamp"].ToTrim()}'");
                        
                        var ret = Imprimir.FillData(_percl, Percll, formasp, ds.Percl, ds.Formasp);
                        var Ps = new PrintSetup
                        {
                            CLocalStamp = CLocalStamp,
                            Inserindo = false,
                            OrigemlabelText = "",
                            Nomfile = Nomfile,
                            Origem = "percl",
                            MdiForm = null,
                            XmlString = xmlstring,
                            DtPrint = ret.dtPrint,
                            Formasp = ret.fp,
                            UseFormasp = true,
                            Ds = ds,
                            Filtro = "",
                            CTituloRelatorio = "",
                            ListaParam = null,
                            Impressora = impressoara.Trim(),
                            NrCopias = numImpresoes,
                            LinguaNacional = lingua
                        };
                        Ps.ReportPath = _reportPath;
                        ReportHelper.PrintReport(Ps);
                    }
                    ReportHelper.Deletefile(_reportPath, Nomfile);
                }
            }
        }

       public string Nomfile { get; set; }

       private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateQuerry();
        }

        private void UpdateQuerry()
        {
            dmzProcura1.SqlComandText=$@"select Processtamp,Descricao=Descricao+ ' '+ ltrim(rtrim(convert(char,codigo)))+'/'+ltrim(rtrim(convert(char,ano)))+' - '+ Mes from proces 
            where ano ={numericUpDown1.Value} order by Codigo";
            dmzProcura2.SqlComandText = $@"select Processtamp,Descricao=Descricao+ ' '+ ltrim(rtrim(convert(char,codigo)))+'/'+ltrim(rtrim(convert(char,ano)))+' - '+ Mes from proces 
            where ano ={numericUpDown1.Value} order by Codigo";
            dmzProcess.SqlComandText = $@"select Processtamp,Descricao=Descricao+ ' '+ ltrim(rtrim(convert(char,codigo)))+'/'+ltrim(rtrim(convert(char,ano)))+' - '+ Mes from proces 
            where ano ={numericUpDown1.Value}  order by Codigo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
             BindGrid();
        }
        private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        {
            //GridProcess.EndEdit();
            //foreach (DataGridViewRow row in GridProcess.Rows)
            //{
            //    var checkBox = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
            //    checkBox.Value = headerCheckBox.Checked;
            //}
        }
        private void HeaderCheckBox2_Clicked(object sender, EventArgs e)
        {
            //gridUi1.EndEdit();
            //foreach (DataGridViewRow row in gridUi1.Rows)
            //{
            //    var checkBox = row.Cells["checkBoxColumn2"] as DataGridViewCheckBoxCell;
            //    checkBox.Value = headerCheckBox.Checked;
            //}
        }
        private void AddHeaderCheckBox(CheckBox headerCheckBox, GridUi grid,EventHandler HeaderCheckBox_Clicked,DataGridViewCellEventHandler _CellClick,string columnName)
        {
            var headerCellLocation = grid.GetCellDisplayRectangle(grid.Columns[columnName.Trim()].Index, -1, true).Location;
            headerCheckBox.Location = new Point(headerCellLocation.X + 3, headerCellLocation.Y + 2);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(22,22);
            headerCheckBox.TextAlign = ContentAlignment.MiddleLeft;
            headerCheckBox.BackColor =grid.ColumnHeadersDefaultCellStyle.BackColor;// Color.FromArgb(34, 39, 49);
            headerCheckBox.Click += HeaderCheckBox_Clicked;
            grid.Controls.Add(headerCheckBox);
            grid.CellContentClick += _CellClick;
        }
        private void GridProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var isChecked = true;
            //foreach (DataGridViewRow row in GridProcess.Rows)
            //{
            //    if (!row.Cells["checkBoxColumn"].EditedFormattedValue.ToBool())
            //    {
            //        isChecked = false;
            //        break;
            //    }
            //}
            //headerCheckBox.Checked = isChecked;
            //UpdateValues();
        }

        private void Calcular()
        {
            if (gridUi1.CurrentRow == null) return;
            var nome = gridUi1.CurrentCell.OwningColumn.Name;
                gridUi1.Update();
                UpdateValues();
            //tbContador.Text = GridProcess.GetChecked("checkBoxColumn").Count.ToString();
            //tbValorReg.Text = GridProcess.GetChecked("checkBoxColumn").Sum(x => x.Cells["valorreg"].Value.ToDecimal()).ToString().SetMask();
        }

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var isChecked = true;
            //foreach (DataGridViewRow row in gridUi1.Rows)
            //{
            //    if (!row.Cells["checkBoxColumn2"].EditedFormattedValue.ToBool())
            //    {
            //        isChecked = false;
            //        break;
            //    }
            //}
            //headerCheckBox2.Checked = isChecked;
            //if (gridUi1.CurrentCell.OwningColumn.Name=="print")
            //{
            //    var xx=gridUi1.CurrentRow.ToDataRow();                
            //    ImprimirRecibos(xx["Perclstamp"].ToString(),xx["no"].ToString());
            //}

            //MenuPrint.Enabled = gridUi1
            //    .Rows[e.RowIndex]
            //    .Cells[e.ColumnIndex]
            //    .Selected;
            if (gridUi1.CurrentCell.OwningColumn.Name == "print")
            {
                MenuPrint.ShowMenuStrip();
            }
        }

        private void ImprimirRecibos(string Perclstamp, string no)
        {
           // Imprimir.DoPrint(Perclstamp,false,"RECIBO DE FUNCIONÁRIO",no,TmpTpgp.Nomfile,"PERCL",this, Linguas.PT);
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



        public DataTable DtConta { get; private set; }


        private void tbSearcRecibos_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false,gridUi1,QryPeRcl,tbProcura.Text);
        }

        private void GridProcess_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (GridProcess.CurrentRow == null) return;
            string qry;
            switch (GridProcess.CurrentCell.OwningColumn.Name.Trim())
            {
                case "Formap":
                    qry = "select CODIGO,Descricao from Fpagam ";
                    Helper.SetBinds(e.Control, "Descricao", qry);
                    break;
                case "Banco":
                    qry = "select sigla from banco ";
                    Helper.SetBinds(e.Control, "sigla", qry);
                    break;

                case "contatesoura":
                    DtConta=Helper.SetBinds(e.Control, "contas", "select * from GetContas()");
                    break;//

            }
        }

        private void GridProcess_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProcess.CurrentRow==null) return;
            var nome = GridProcess.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("contatesoura"))
            {
                if (GridProcess.CurrentCell == null) return;
                if (DtConta==null) return;
                var valor = GridProcess.CurrentCell.Value.ToString().Trim();
                var dr = DtConta.AsEnumerable().FirstOrDefault(s => s.Field<string>("contas").Trim().Equals(valor));
                if (dr == null) return;
                GridProcess.CurrentRow.Cells["codtz"].Value = dr[0].ToDecimal();
                GridProcess.CurrentRow.Cells["banco"].Value = dr["sigla"].ToDecimal();
                GridProcess.CurrentRow.Cells["Contasstamp"].Value = dr["Contasstamp"].ToString().Trim();
            }
            if (nome.Equals("checkboxcolumn"))
            {
                Calcular();
            }
        }

        private void tbFormas_RefreshControls()
        {
            UpdateGrid("Formap",tbFormas.tb1.Text);
        }

        private void tbBanco_RefreshControls()
        {
            UpdateGrid("banco",tbBanco.tb1.Text);
        }

        private void UpdateGrid(string campo, string text)
        {
            if (GridProcess.HasRows())
            {
                foreach (DataGridViewRow row in GridProcess.Rows)
                {
                    row.Cells[campo.Trim()].Value = text.IsNullOrEmpty()?"": text.Trim();
                }
                GridProcess.Invokex(x=>x.Update());
            }
        }

        private void tbConta_RefreshControls()
        {
            if (!GridProcess.HasRows()) return;
            foreach (DataGridViewRow row in GridProcess.Rows)
            {
                row.Cells["codtz"].Value = tbConta.Text3;
                row.Cells["contatesoura"].Value = tbConta.tb1.Text;
                row.Cells["Contasstamp"].Value = tbConta.Text2;
                row.Cells["banco"].Value = tbConta.Text4;
            }
            GridProcess.Invokex(x=>x.Update());
        }

        private void UpdateValues()
        {
            var nome = GridProcess.CurrentCell.OwningColumn.Name;
            if (nome.Equals("checkBoxColumn"))
            {
                GridProcess.EndEdit();
                Somatorio();
            }
        }

        private void Somatorio()
        {
            if (QryPecc.HasRows())
            {
                GridProcess.Update();
                if (QryPecc.AsEnumerable().Any(x => x.Field<bool?>("ok").Equals(true)))
                {
                    tbContador.Text = QryPecc.AsEnumerable().Where(x => x.Field<bool?>("ok").Equals(true)).CopyToDataTable().Rows.Count.ToString();
                    var valor = QryPecc.AsEnumerable().Where(x => x.Field<bool?>("ok").Equals(true)).Sum(x => x.Field<decimal>("valorreg"));
                    tbValorReg.Text = valor.ToString().SetMask();
                }
                else
                {
                    tbContador.Text = "0";
                    tbValorReg.Text = "0";
                }
            }
            else
            {
                tbContador.Text = "0";
                tbValorReg.Text = "0";
            }
        }

        private void cbDefault1_CheckedChangeds()
        {
            GridProcess.CheckUncheckAll("checkBoxColumn",cbDefault1.cb1.Checked);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Nomfile = TmpTpgp.XmlString;
            var frmset = new FrmPrintset();
            frmset.DadosEnviados += DadosInfo;
            frmset.ShowForm(this, true);
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomfile = TmpTpgp.XmlStringa5;
            var frmset = new FrmPrintset();
            frmset.DadosEnviados += DadosInfo;
            frmset.ShowForm(this, true);
        }

        private void cbDefault3_Load(object sender, EventArgs e)
        {

        }

        private void cbDefault2_CheckedChangeds()
        {
            gridUi1.CheckUncheckAll("checkBoxColumn2", cbDefault2.cb1.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dmzProcura1.Text2.IsNullOrEmpty())
            {
                BindGridRcl2(dmzProcura1.Text2.Trim());
            }

        }

        private void BindGridRcl2(string Processtamp)
        {
            var str = $@"	Select percl.numero,percl.data,nomecomerc,percl.no,percl.nome,percl.moeda,percl.total,percl.anulado,percl.obs
	,percll.descricao,percll.nrdoc,percll.data as datadoc,percll.valorpreg,percll.valorreg
	,Morada=isnull((Select bairro from pe where Pestamp=percl.Pestamp),''),Nuit=isnull((Select nuit from pe where Pestamp=percl.Pestamp),0),localidade=''
	,percll.numinterno,percl.nomedoc,nano=year(percll.data),cambiousd,moeda2,Mtotal,Valordoc,ValorPend,Pestamp,Processtamp,cast(0 as bit) as ok, percl.Perclstamp
	 from percl percl (nolock) inner join percll  (nolock) on percl.Perclstamp=percll.Perclstamp
            WHERE Processtamp='{Processtamp.Trim()}'";

            QryPeRcl = SQL.GetGen2DT(str);
            gridUi1.Invokex(x => x.DataSource = null);
            gridUi1.Invokex(x => x.AutoGenerateColumns = false);
            gridUi1.Invokex(x => x.DataSource = QryPeRcl);
        }

        private void btnSearchRecibo_Click(object sender, EventArgs e)
        {
            if (!dmzProcura2.tb1.Text.IsNullOrEmpty())
            {
                BindGridRcl(dmzProcura2.tb1.Text.Trim());
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve indicar o processamento!");
            }
        }

        private void BindGridRcl(string processtamp)
        {
            var str = $@"select cast(0 as bit) as ok,percl.nome,Titulo,Contatesoura,Dcheque as data,valor as valorreg,Nomedoc,Codtz,origem,Formaspstamp,percl.Perclstamp,Nomecomerc as descricao,ok=cast(0 as bit) 
                        from percl join Formasp on Percl.Perclstamp=Formasp.Perclstamp where Processtamp='{processtamp.Trim()}'";
            QryPecc = SQL.GetGen2DT(str);
            GridProcess.Invokex(x => x.DataSource = null);
            GridProcess.Invokex(x => x.AutoGenerateColumns = false);
            GridProcess.Invokex(x => x.DataSource = QryPecc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var dt = GridProcess.GetBindedTable();
            //if (!dt.HasRows()) return;
            //dt = dt.Select("ok=1").CopyToDataTable();
            //if (!dt.HasRows()) return;
            //Helper.DoProgressProcess(dt, RecebeDados2);
            GridProcess.Update();
            var dr = MsBox.Show(Messagem.ParteInicial() + "Deseja que o Software actualize o(s) recibo(s) seleccionado(s)?", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            //if (!Valido()) return;
            if (QryPecc.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
            {
                QryPecc = QryPecc.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                Helper.DoProgressProcess(QryPecc, RecebeDados2);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Porfavor deve selecionar a(s) linha(s) que pretende processar!");
            }
        }

        private void RecebeDados2(DataRow dr, bool fim)
        {
            if (!dr.DataRowIsNull())
            {
                var p = SQL.GetRowToEnt<Formasp>($"Formaspstamp ='{dr["Formaspstamp"].ToString().Trim()}'");// EF.GetEnt<Formasp>(x => x.Formaspstamp.Equals(dr["Formaspstamp"].ToString().Trim()));
                if (p!=null)
                {
                    p.Titulo = dr["Titulo"].ToString();
                    p.Contatesoura = dr["Contatesoura"].ToString();
                    p.Codtz = dr["Codtz"].ToDecimal();
                    EF.Save(p);
                }
            }
            if (fim)
            {
                //gridUi1.Invokex(x => x.DataSource = null);
                //gridUi1.Invokex(x => x.AutoGenerateColumns = false);
                //gridUi1.Invokex(x => x.DataSource = QryPeRcl);
                //BindGrid();
                Alert("Recibo(s) actualizado(s) com sucesso!", Form_Alert.EnmType.Success);
            }
        }

        private void GridProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProcess.CurrentRow == null) return;
            GridProcess.Update();
            UpdateValues();
        }
    }
}
