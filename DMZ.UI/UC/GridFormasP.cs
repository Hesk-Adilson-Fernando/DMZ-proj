using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UC
{
    public partial class GridFormasP : UserControl
    {
        private Form _myParent;
        public DataTable Formaspdt { get; set; }
        public DataRow Dr;
        private DateTimePicker dtp;
        private Panel panel;
        public string StampCabName { get; set; }
        public AnchorStyles GridAnchorStyles
        {
            get => Grelha.Anchor;
            set => Grelha.Anchor = value;
        }
        public DataGridViewCellStyle RowHeadersDefaultCellStyle
        {
            get => Grelha.RowHeadersDefaultCellStyle;
            set => Grelha.RowHeadersDefaultCellStyle = value;

        }
        public DataGridViewCellStyle RowsDefaultCellStyle
        {
            get => Grelha.RowsDefaultCellStyle;
            set => Grelha.RowsDefaultCellStyle = value;
        }
        public DataGridViewCellStyle DefaultCellStyle
        {
            get => Grelha.DefaultCellStyle;
            set => Grelha.DefaultCellStyle = value;
        }

        public DataGridViewCellStyle ColumnHeadersDefaultCellStyle
        {
            get => Grelha.ColumnHeadersDefaultCellStyle;
            set => Grelha.ColumnHeadersDefaultCellStyle = value;
        }

        public GridFormasP()
        {
            InitializeComponent();
            dtp= new DateTimePicker();
            panel =new Panel();

            //Grelha.Controls.Add(dtp);
            //Grelha.Controls.Add(panel);
            panel.Visible = false;
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += dtp_TextChebged;
        }

        private void GridPrest_Load(object sender, EventArgs e)
        {

        }

        public  void Refresh(decimal numdoc)
        {
            if (numdoc ==2)
            {
                Visible = true;
                Movtz = true;
            }
            else
            {
                Visible = false;
                Movtz = false;
            }

        }

        private void Grelha_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (Grelha.CurrentRow == null) return;
            string qry;
            switch (Grelha.CurrentCell.OwningColumn.Name.Trim())
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
                    DtConta=Helper.SetBinds(e.Control, "contas", "select * from GetContas()");
                    break;//
                case "Contadestino":
                    DtConta2 = Helper.SetBinds(e.Control, "contas", "select * from GetContas()");
                    break;//
                case "Moeda":
                    DtConta2 = Helper.SetBinds(e.Control, "Moeda", "select Moeda from moedas");
                    break;//
            }
        }

        public DataTable DtConta2 { get; set; }

        public DataTable DtConta { get; set; }

        private void Grelha_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddLinha();

        }

        public void AddLinha()
        {
            _myParent = ParentForm;
            if (_myParent == null) return;
            decimal codconta = 0;
            if (_myParent.ParentForm != null)
            {
                var pf = _myParent.ParentForm.Name;
                if (Pbl.Usr.Codtz.ToDecimal()==0)
                {
                    if (pf.Equals("DemoMdi"))
                    {
                        codconta = Pbl.Usr.Codtz;
                    }
                }
                else
                {
                    codconta = Pbl.Usr.Codtz.ToDecimal();
                }
            }
            if (!((FrmClasse)_myParent).EditMode) return;
            Dr = Formaspdt.NewRow().Inicialize();
            Dr[StampCabName] = ((FrmClasse)_myParent).CLocalStamp;
            Dr["Origem"] = _myParent.Name;
            Dr["Dcheque"] = Pbl.SqlDate;
            Dr["Contatesoura"] = Pbl.Usr.ContaTesoura??"";
            Dr["Codtz"] = codconta;
            Dr["banco"] = Pbl.Usr.Sigla??""; 
            Dr["UsrLogin"] = Pbl.Usr.Usrstamp;
            Dr["Contasstamp"] = Pbl.Usr.Contasstamp;//
            Dr["Ccustamp"] = Pbl.Usr.Ccustamp;//gdView.Grelha.CurrentRow.Cells["Moeda"].Value = ucMoeda.tb1.Text;
            Dr["Moeda"] = Pbl.MoedaBase;
            Formaspdt.Rows.Add(Dr);

            if (_myParent is FrmClasse)
            {
                ((FrmClasse)_myParent).UpdGridFormasp();
            }
        }


        public string Origem { get; set; }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (Grelha.Rows.Count <= 0) return;
            if (Grelha.CurrentRow == null) return;
            DellLine();
        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        public void DellLine()
        {
            var dr = (Grelha.CurrentRow?.DataBoundItem as DataRowView)?.Row;//
            if (dr == null) return;
            var dres = MsBox.Show($"Deseja eliminar a conta:\r\n {Grelha.CurrentRow.Cells["contatesoura"].Value.ToString().Trim()} ?\r\n Valor: {Grelha.CurrentRow.Cells["Valor"].Value.ToString()}", DResult.YesNo);
            if (dres.DialogResult != DialogResult.Yes) return;
            if (dr.RowState!= DataRowState.Added)
            {
                var res = SQL.SqlCmd($"delete from formasp where formaspstamp='{dr["formaspstamp"].ToString().Trim()}'");
                if (res >0)
                {
                    MsBox.Show("Registo elimeinado com sucesso");
                    Grelha.Rows.Remove(Grelha.CurrentRow);
                    //var dt = Grelha.DataSource as DataTable;
                   // dt = dt?.AsEnumerable().Where(x => x.RowState != DataRowState.Deleted).CopyToDataTable();
                    Update();
                }
                else
                {
                    MsBox.Show("Erro encontrado. Tente de novo");
                }
            }
            else
            {
                MsBox.Show("Registo elimeinado com sucesso");
                Grelha.Rows.Remove(Grelha.CurrentRow);
                //var dt = Grelha.DataSource as DataTable;
                //dt = dt?.AsEnumerable().Where(x => x.RowState != DataRowState.Deleted).CopyToDataTable();
                Update();
            }
        }

        public void UpdateLine(decimal valor)
        {
            var dt = Grelha.DataSource as DataTable;
            if (dt !=null)
            {
                var novoValor = dt.Rows[0]["Valor"].ToDecimal() - valor;
                var novoMValor = dt.Rows[0]["MValor"].ToDecimal() - valor;
                dt.Rows[0]["Valor"] = novoValor;
                dt.Rows[0]["MValor"] = novoMValor;
            }
            Grelha.EndEdit();
            Grelha.DataSource = null;
            Grelha.DataSource = dt;
        }
        //public void SaveData()
        //{
        //    if (!(Formaspdt?.Rows.Count > 0)) return;
        //    SQL.GravaTabela(Formaspdt, "Formasp");
        //}
        public bool Movtz { get; set; }
        public (int numero,string messagem) SaveData(bool adding, string ctabela,string clocalstamp)
        {
            (int numero, string messagem) retorno = (20, null);
            if (Formaspdt?.Rows.Count > 0)
            {
                retorno=  SQL.Save(Formaspdt, "Formasp",adding,clocalstamp,ctabela);
            }
            return retorno;
        }
        public void BindGridView(bool state)
        {
            _myParent = Parent?.FindForm();
            var stampValue = ((FrmClasse) _myParent)?.CLocalStamp;
            if (stampValue != null && StampCabName != null)
            {
                var query = state ? $"select * from Formasp where {StampCabName.Trim()}='{stampValue.Trim()}'" : "select * from Formasp where 1=0";
                Formaspdt = SQL.GetGen2DT(query);
            }
            Grelha.EndEdit();
            Grelha.DataSource = null;
            Grelha.AutoGenerateColumns = false;
            Grelha.DataSource = Formaspdt;
        }

        private void dtp_TextChebged(object sender, EventArgs e)
        {
            Grelha.CurrentCell.Value = dtp.Text;
        }

        private void Grelha_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Grelha.CurrentRow==null) return;
            var nome = Grelha.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("contatesoura"))
            {
                if (Grelha.CurrentCell == null) return;
                if (DtConta==null) return;
                var valor = Grelha.CurrentCell.Value.ToString().Trim();
                var dr = DtConta.AsEnumerable().FirstOrDefault(s => s.Field<string>("contas").Trim().Equals(valor));
                if (dr == null) return;
                if (Grelha.CurrentRow == null) return;
                Grelha.CurrentRow.Cells["Codtz"].Value = dr[0].ToDecimal();
                Grelha.CurrentRow.Cells["banco"].Value = dr["sigla"].ToDecimal();
                //Contasstamp
                Grelha.CurrentRow.Cells["Contasstamp"].Value = dr["Contasstamp"].ToString().Trim();
            }
            if (nome.Equals("contadestino"))
            {
                if (Grelha.CurrentCell == null) return;
                var valor = Grelha.CurrentCell.Value.ToString().Trim();
                var dr = DtConta2?.AsEnumerable().FirstOrDefault(s => s.Field<string>("contas").Trim().Equals(valor));
                if (dr == null) return;
                if (Grelha.CurrentRow == null) return;
                Grelha.CurrentRow.Cells["Codtz2"].Value = dr[0].ToDecimal();
                Grelha.CurrentRow.Cells["Bancoentrada"].Value = dr["sigla"].ToDecimal();
                Grelha.CurrentRow.Cells["Contasstamp2"].Value = dr["Contasstamp"].ToString().Trim();
            }
            if (nome.Equals("dcheque"))
            {
                Helper.AddDateTimePicker(Grelha,e); 
            }
        }

        private void Grelha_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (Grelha.CurrentRow==null) return;
            var nome = Grelha.CurrentCell.OwningColumn.Name.ToLower();
            if (!nome.Equals("contatesoura")) return;
            if (string.IsNullOrEmpty(Grelha.CurrentCell.Value.ToString()))
            {
                MsBox.Show("A conta não pode ser vazio, Favor de preencher!");
                
            }
        }

        internal void UpdateDS(DataTable dtFormasp)
        {
            Grelha.DataSource= null;
            Grelha.AutoGenerateColumns=false;
            Grelha.DataSource=dtFormasp;
        }
    }
    }


      
