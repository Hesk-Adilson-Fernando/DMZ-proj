using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using Utilities = DMZ.BL.Classes.Utilities;

namespace DMZ.UI.UI
{
    public partial class FrmEncontrocontas : FrmClasse2
    {
        public FrmEncontrocontas()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }
        private DataTable QryPecc;

        private DataTable Qrypgf;
        public DataTable Formaspdtfnc { get; set; }
        public DataTable Formaspdtcl { get; set; }
        public DataRow Dr;
        private void FrmEncontrocontas_Load(object sender, EventArgs e)
        {
            TmpTpgf = SQL.GetRowToEnt<Tpgf>(" defa=1 ");
            _pgf = Utilities.DoAddline<Pgf>();
            _pgf.Numdoc = TmpTpgf.Numdoc;
            _pgf.Nomedoc = TmpTpgf.Descricao;
            _pgf.Ccusto = Pbl.Usr.Ccusto;
            _pgf.Codmovcc = TmpTpgf.Codmovcc;
            _pgf.Descmovcc = TmpTpgf.Descmovcc;
            _pgf.Codmovtz = TmpTpgf.Codmovtz;
            _pgf.Descmovtz = TmpTpgf.Descmovtz;
            _pgf.Sigla = TmpTpgf.Sigla;
            _pgf.Rcladiant = TmpTpgf.Rcladiant;
            Formaspdtfnc = SQL.Initialize("Formasp");
            BindGridView();
            Formaspdtcl = SQL.Initialize("Formasp");
            _pgfl = SQL.Initialize("Pgfl");
            _rcll = SQL.Initialize("rcll");
        }
        private void FillPercl(DataRow p, DataRow dr)
        {

            p["Codmovtz"] = TmpTpgf.Codmovtz;
            p["Descmovtz"] = TmpTpgf.Descmovtz;
            p["Codmovcc"] = TmpTpgf.Codmovcc;
            p["Descmovcc"] = TmpTpgf.Descmovcc;
            p["No"] = dr["no"].ToString();
            p["Nome"] = dr["nome"].ToString();
            p["Numdoc"] = TmpTpgf.Numdoc;
            p["Nomedoc"] = TmpTpgf.Descricao;
            p["Sigla"] = TmpTpgf.Sigla;
            p["Moeda"] = dr["moeda"].ToString();
            p["Total"] = p["Total"].ToDecimal() + dr["valorreg"].ToDecimal();
            p["Data"] = dtData.dt1.Value;
            p["Ccusto"] = tbCCusto.tb1.Text;
            p["Obs"] = tbObs.Text;
            p["Numdoc"] = TmpTpgf.Numdoc;
            p["Nomedoc"] = TmpTpgf.Descricao;
            p["Codmovcc"] = TmpTpgf.Codmovcc;
            p["Descmovcc"] = TmpTpgf.Descmovcc;
            p["Codmovtz"] = TmpTpgf.Codmovtz;
            p["Descmovtz"] = TmpTpgf.Descmovtz;
            p["Sigla"] = TmpTpgf.Sigla;
            var x = SQL.Maximo($"Percl", "numero", $"Ccusto ='{Pbl.Usr.Ccusto.Trim()}'");
            p["Numero"] = x;
        }

        RCL _rcl;
        private DataTable _rcll;
        public Tpgf TmpTpgf { get; set; }
        public Pgf _pgf;
        private DataTable _pgfl;

        private void GetValue(DataRow r)
        {
            Helper.FillRcl(_pgfl, r, _pgf.Pgfstamp, "pgf");
        }
        private void RecebeDados(bool fim=true)
        {
            DataTable dt;
            var ss = _pgfl.Select("tipo=2");
            if (ss.Length>0)
            {
                dt = ss.CopyToDataTable();

                var ssssssss =SQL.Initialize("pgfl");
                foreach (var r in dt.AsEnumerable())
                {
                    DataRow drRow = ssssssss.NewRow();
                    for (int i = 0; i < ssssssss.Columns.Count; i++)
                    {
                        var nam = ssssssss.Columns[i].ColumnName.ToTrim();
                        drRow[nam] = r[nam];
                        drRow[nam] = r[nam];
                        drRow[nam] = r[nam];
                    }
                    ssssssss.Rows.Add(drRow);
                }
                EF.Save(_pgf);
                SQL.Save(ssssssss, "pgfl", true, _pgf.Pgfstamp, "pgf");
                SQL.Save(Formaspdtfnc, "Formasp", true, _pgf.Pgfstamp, "pgf");
                if (fim)
                {
                    GridProcess.Invokex(x => x.DataSource = null);
                    GridProcess.Invokex(x => x.AutoGenerateColumns = false);
                    GridProcess.Invokex(x => x.DataSource = _pgfl);
                    BindGrid();
                    Alert("Recibo(s) processado(s) com sucesso!", Form_Alert.EnmType.Success);
                }
            }
        }


        private void UpdateGrid(string campo, string text)
        {
            if (GridProcess?.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridProcess.Rows)
                {
                    row.Cells[campo.Trim()].Value = text.Trim();
                }
                GridProcess.Invokex(x => x.Update());
            }
        }
        private void BindGrid()
        {
          var  str = $"select * " +
                  $"from(select *,tipo=1,deb=valorpreg,cre=0 from clccf() where clstamp='469D20222DMZ518132' " +
                  $"union  all select upper('Ttl CC Cl'),'','',sum(valordoc),sum(valorpreg),sum(valorreg),0,'','','','',0,'','',0,'','',''," +
                  $"'',tipo=0,sum(valorpreg),cre=0 from clccf() where clstamp='469D20222DMZ518132' union  all select *,tipo=2,deb=0,cre=valorpreg " +
                  $"from fncccf() where fncstamp='469D20222DMZ518132' union  all select upper('Ttl CC Fnc'),'',''," +
                  $"sum(valordoc),sum(valorpreg),sum(valorreg),0,'','','','',0,'','',0,'','','','',tipo=0,deb=0,cre=sum(valorpreg)  " +
                  $"from fncccf() where fncstamp='469D20222DMZ518132' union  all select upper('Total Geral'),'','',ss=((select -(sum(valordoc)) from fncccf() " +
                  $"where fncstamp='469D20222DMZ518132' )+(select sum(valordoc) from clccf() where clstamp='469D20222DMZ518132' )),sum(0),sum(0),0,'','',''," +
                  $"'',0,'','',0,'','','','',tipo=0,deb=0,cre=0 )temp ";
             var dt = SQL.GetGen2DT(str);
            if (dt.HasRows())
            {
                foreach (var r in dt.AsEnumerable())
                {
                    r["valordoc"] = r["valordoc"].ToDecimal();
                    r["valorpreg"] = r["valorpreg"].ToDecimal();
                    r["valorreg"] = r["valorreg"].ToDecimal();
                }
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    var name = dt.Columns[i].ColumnName.ToLower();
                    if (name.Equals("ccstamp"))
                    {
                        dt.Columns[i].ColumnName = "fccstamp";
                    }
                }
                
                var f = new FrmReg { Tabela = dt, SendData = ReceiveData, OrigemDoc = true, Origemsssss = 1 };
                f.ShowForm(this);

               // tbTotalregisto.Invokex(k => k.Text = QryPecc.Rows.Count.ToString().SetMask());
                //tbTotalValor.Invokex(k => k.Text = QryPecc.AsEnumerable().Sum(x => x.Field<decimal>("valorpreg")).ToString().SetMask());
                //GridProcess.Invokex(x => x.DataSource = null);
                //GridProcess.Invokex(x => x.AutoGenerateColumns = false);
                //GridProcess.Invokex(x => x.DataSource = QryPecc);
                //UpdateGrid("Formap", tbFormas.tb1.Text);
                //UpdateGrid("banco", tbBanco.tb1.Text);
                //tbConta_RefreshControls();
                //tbContador.Invokex(x => x.Text = "");
                //tbValorReg.Invokex(x => x.Text = "");
            }
            else
            {
                MsBox.Show("O Fornecedor não tem movimentos");
            }
        }

        private decimal Total;
        private decimal Mtotal;
        private void tbConta_RefreshControls()
        {
            if (GridProcess?.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridProcess.Rows)
                {
                    row.Cells["codtz"].Value = tbConta.Text3;
                    row.Cells["contatesoura"].Value = tbConta.tb1.Text;
                    row.Cells["Contasstamp"].Value = tbConta.Text2;
                }
                GridProcess.Invokex(x => x.Update());
            }
        }
        public void ReceiveData(DataTable dataRows)
        {
            Total = 0;
            Mtotal = 0;
            foreach (var r in dataRows.AsEnumerable().Where(r => r != null))
            {
                GetValue(r);
            }
            if (_pgfl != null)
            {
                if (!_pgfl.Columns.Contains("tipo"))
                {
                    _pgfl.Columns.Add("tipo", typeof(string));
                }
                foreach (var r in _pgfl.AsEnumerable().Where(r => r != null))
                {
                    foreach (var rr in dataRows.AsEnumerable().Where(rr => rr != null))
                    {
                        if (r["fccstamp"].ToString().Equals(rr["fccstamp"].ToString()))
                        {
                            r["tipo"] = rr["tipo"].ToString();
                        }
                    }
                    Total += r["valorreg"].ToDecimal();
                    Mtotal += r["mvalorreg"].ToDecimal();
                }


            }
            GridProcess.Invokex(x => x.DataSource = null);
            GridProcess.Invokex(x => x.AutoGenerateColumns = false);
            GridProcess.Invokex(x => x.DataSource = _pgfl);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddprocess_Click(object sender, EventArgs e)
        {
            RecebeDados();
        }

        void selectAll(bool sel)
        {
            foreach (DataGridViewRow r in GridProcess.Rows)
            {
                r.Cells["checkBoxColumn"].Value = sel;
            }
        }
        private void cbDefault1_CheckedChangeds()
        {
            selectAll(cbDefault1.cb1.Checked);
        }

        void FillFormasP(DataTable formasp)
        {
            decimal codconta = 0;
            if (Pbl.Usr.Codtz.ToDecimal() == 0)
            {
                codconta = Pbl.Usr.Codtz;
            }
            else
            {
                codconta = Pbl.Usr.Codtz.ToDecimal();
            }
            Dr = Formaspdtfnc.NewRow().Inicialize().Inicialize();
            Dr["Pgfstamp"] = _pgf.Pgfstamp;
            Dr["Formaspstamp"] = Pbl.Stamp();
            Dr["Origem"] = "FrmPgf";
            Dr["valor"] = 0;
            Dr["Dcheque"] = Pbl.SqlDate;
            Dr["Contatesoura"] = Pbl.Usr.ContaTesoura ?? "";
            Dr["Codtz"] = codconta;
            Dr["banco"] = Pbl.Usr.Sigla ?? "";
            Dr["Numer"] = false;
            Dr["Cpoc"] = 0;
            Dr["ContaPgc"] = 0;
            Dr["Mvalor"] = 0;
            Dr["Codmovtz"] = 0;
            Dr["Descmovtz"] = "";
            Dr["Codmovtz2"] = 0;
            Dr["Descmovtz2"] = "";
            Dr["UsrLogin"] = Pbl.Usr.Usrstamp;
            Dr["Contasstamp"] = Pbl.Usr.Contasstamp;//
            Formaspdtfnc.Rows.Add(Dr);
            if (Formaspdtfnc.Rows.Count==1)
            {
                var sssss = _pgfl.Select("tipo=2");
                if (sssss.Length > 0)
                {
                    var sum = sssss.CopyToDataTable().Sum("valorreg").ToDecimal();
                    Formaspdtfnc.Rows[0]["valor"] = sum;
                }
            }
            UpdGridFormasp();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FillFormasP(Formaspdtfnc);
        }
        public void BindGridView()
        {
            Grelhafnc.EndEdit();
            Grelhafnc.DataSource = null;
            Grelhafnc.AutoGenerateColumns = false;
            Grelhafnc.DataSource = Formaspdtfnc;
        }
        public  void UpdGridFormasp()
        {
            Helper.Codmovtz(true, TmpTpgf.Codmovtz, TmpTpgf.Descmovtz, Grelhafnc, "pgf");
        }


        public  void Codmovtzsssss(bool movtz, decimal codmovtz, string descmovtz, DataGridView grelha, string origem = "")
        {
            if (!movtz) return;
            if (grelha.CurrentRow == null) return;
            grelha.CurrentRow.Cells["Codmovtz"].Value = codmovtz;
            grelha.CurrentRow.Cells["Descmovtz"].Value = descmovtz;//Origem2
            grelha.CurrentRow.Cells["Origem2"].Value = origem;//
        }


        public DataTable DtConta2 { get; set; }

        public DataTable DtConta { get; set; }

        private void Grelha_EditingControlShowing(DataGridView sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (sender.CurrentRow == null) return;
            string qry;
            switch (sender.CurrentCell.OwningColumn.Name.Trim())
            {
                case "titulo":
                    qry = "select CODIGO,Descricao from Fpagam ";
                    Helper.SetBinds(e.Control, "Descricao", qry);
                    break;
                case "banco":
                    qry = "select sigla from banco ";
                    Helper.SetBinds(e.Control, "sigla", qry);
                    break;
                case "Bancoentrada":
                    qry = "select sigla from banco ";
                    Helper.SetBinds(e.Control, "sigla", qry);
                    break;
                case "contatesoura":
                    DtConta = Helper.SetBinds(e.Control, "contas", "select * from GetContas()");
                    break; //
                case "Contadestino":
                    DtConta2 = Helper.SetBinds(e.Control, "contas", "select * from GetContas()");
                    break; //
            }
        }
        private void Grelha_CellEndEdit(DataGridView sender, DataGridViewCellEventArgs e)
        {
            if (sender.CurrentRow == null) return;
            var nome = sender.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("contatesoura"))
            {
                if (sender.CurrentCell == null) return;
                if (DtConta == null) return;
                var valor = sender.CurrentCell.Value.ToString().Trim();
                var dr = DtConta.AsEnumerable().FirstOrDefault(s => s.Field<string>("contas").Trim().Equals(valor));
                if (dr == null) return;
                if (sender.CurrentRow == null) return;
                sender.CurrentRow.Cells["Codtz"].Value = dr[0].ToDecimal();
                sender.CurrentRow.Cells["banco"].Value = dr["sigla"].ToDecimal();
                //Contasstamp
                sender.CurrentRow.Cells["Contasstamp"].Value = dr["Contasstamp"].ToString().Trim();
            }
            if (nome.Equals("contadestino"))
            {
                if (sender.CurrentCell == null) return;
                var valor = sender.CurrentCell.Value.ToString().Trim();
                var dr = DtConta2?.AsEnumerable().FirstOrDefault(s => s.Field<string>("contas").Trim().Equals(valor));
                if (dr == null) return;
                if (sender.CurrentRow == null) return;
                sender.CurrentRow.Cells["Codtz2"].Value = dr[0].ToDecimal();
                sender.CurrentRow.Cells["Bancoentrada"].Value = dr["sigla"].ToDecimal();
                sender.CurrentRow.Cells["Contasstamp2"].Value = dr["Contasstamp"].ToString().Trim();
            }
            sender.CurrentCell.Value = sender.CurrentCell.Value.ToString().ToUpper();
            if (nome.Equals("dcheque"))
            {
                Helper.AddDateTimePicker(sender, e);
            }
        }

        private void Grelha_CellValidated(DataGridView sender, DataGridViewCellEventArgs e)
        {
            if (sender.CurrentRow == null) return;
            var nome = sender.CurrentCell.OwningColumn.Name.ToLower();
            if (!nome.Equals("contatesoura")) return;
            if (string.IsNullOrEmpty(sender.CurrentCell.Value.ToString()))
            {
                MsBox.Show("A conta não pode ser vazio, Favor de preencher!");

            }
        }

        private void Grelha_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Grelha_EditingControlShowing(Grelhafnc, e);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Grelha_EditingControlShowing(dataGridView1, e);
        }

        private void Grelha_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Grelha_CellEndEdit(Grelhafnc, e);
        }

        private void Grelha_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            Grelha_CellValidated(Grelhafnc, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillFormasP(Formaspdtcl);
        }
    }
}
