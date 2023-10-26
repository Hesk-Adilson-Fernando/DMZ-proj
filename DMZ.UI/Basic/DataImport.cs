using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;

namespace DMZ.UI.Basic
{
    public partial class DataImport : FrmClasse2
    {
        public string CLocalStamp { get; private set; }

        public DataImport()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var dt = gridUi1.DataSource as DataTable;
            Helper.DoProgressProcess(dt, RecebeDados);
        }

        private void RecebeDados(DataRow dr,bool fim)
        {
            St st;
            var existe = SQL.CheckExist($"select referenc from st where ltrim(rtrim(referenc)) ='{dr["Referenc"].ToString().Trim()}'");
            if (!existe)
            {
                st = Utilities.DoAddline<St>();
                st.Ststamp = Pbl.Stamp("MMC");
                st.Status = "Activo";
                //st.Stock=dr["quant"].ToDecimal();
                st.Familia = dr["Familia"].ToString();
                st.Codfam = dr["Codfam"].ToString();
                st.Descricao = dr["Descricao"].ToString();
                st.Referenc = string.IsNullOrEmpty(dr["Referenc"].ToString()) ? dr["Descricao"].ToString() : dr["Referenc"].ToString();
                st.Obs = dr["Obs"].ToString();
                st.Tabiva = dr["Tabiva"].ToDecimal();
                st.Txiva = dr["Txiva"].ToDecimal();
                st.Unidade = dr["Unidade"].ToString();
                st.Subfamilia=dr["Subfamilia"].ToString();
                var stpreco = SQL.GetGen2DT("select * from stprecos where 1=0");
                var dr2 = stpreco.NewRow();
                dr2["StPrecostamp"]= Pbl.Stamp();
                dr2["Ststamp"]= st.Ststamp;
                dr2["CodCCu"]= dr["CodCcu"];
                dr2["CCusto"] = dr["CCusto"];
                dr2["Preco"] = dr["Preco"];
                dr2["ivainc"] = true;
                stpreco.Rows.Add(dr2);
                var starm = SQL.GetGen2DT("select * from Starm where 1=0");
                var dr3 = starm.NewRow();
                dr3["Starmstamp"]= Pbl.Stamp();
                dr3["Ststamp"]= st.Ststamp;
                dr3["Codarm"]= dr["Codarm"];
                dr3["Descricao"]= dr["Armazem"].ToString().ToUpper();
                dr3["ref"] = st.Referenc;
                dr3["stock"] = 0;// dr["quant"];
                starm.Rows.Add(dr3);
                st.Stockmin = 0;
                EF.Save(st);
                //InsertMstk(dr,st);
                SQL.Save(stpreco, "StPrecos", true, CLocalStamp, "st");
                SQL.Save(starm, "Starm", true, CLocalStamp, "st");
            }
            else
            {
                //var dt = SQL.GetGen2DT($"select * from st where ltrim(rtrim(referenc)) ='{dr["Referenc"].ToString().Trim()}'");
                //if (!(dt?.Rows.Count > 0)) return;
                //dt.Rows[0]["Stock"] = dt.Rows[0]["Stock"].ToDecimal()+dr["quant"].ToDecimal();
                //SQL.Save(dt, "st", true, "", "");
                //st = dt.DtToList<St>()[0];
                //InsertMstk(dr,st);
                //var starm = SQL.GetGen2DT("select * from Starm where 1=0");
                //var dr3 = starm.NewRow();
                //dr3["Starmstamp"]= Pbl.Stamp();
                //dr3["Ststamp"]= dt.Rows[0]["Ststamp"];
                //dr3["Codarm"]= dr["Codarm"];
                //dr3["Descricao"]= dr["Armazem"].ToString().ToUpper();
                //dr3["ref"] =dt.Rows[0]["Referenc"] ;
                //dr3["stock"] = 0;// dr["quant"];
                //starm.Rows.Add(dr3);
                //SQL.Save(starm, "Starm", true, CLocalStamp, "st");
            }

        }

        void InsertMstk(DataRow dr,St st)
        {
            var mstk= Utilities.DoAddline<Mstk>();
            mstk.Mstkstamp = Pbl.Stamp("MMC");
            mstk.Origem = "IMP";
            mstk.Entrada=dr["quant"].ToDecimal();
            mstk.Data = Pbl.SqlDate;
            mstk.Ccusto=dr["CCusto"].ToString();
            mstk.Codccu=dr["CodCcu"].ToString();
            mstk.Codarm= dr["Codarm"].ToDecimal();
            mstk.Tipodoc = "SI";
            mstk.Oristamp = st.Ststamp;
            mstk.Codmovstk = 11;
            mstk.Descmovstk = "NE/Stock Inicial";
            mstk.Nrdoc = 1;
            mstk.Preco= dr["Preco"].ToDecimal();
            mstk.Documento = "Stock Inicial";
            mstk.Moeda = "MZN";
            mstk.No = 1;
            mstk.Nome = "DMZ IMPORT";
            mstk.Dilstamp = null;
            mstk.Facclstamp = null;
            mstk.Numdoc = 4;
            mstk.Factlstamp = null;
            mstk.Ivlstamp = null;
            mstk.Ref = st.Referenc;
            mstk.Descricao = st.Descricao;
            mstk.Stampcab = st.Ststamp;
            EF.Save(mstk);
        }
        public event Action<DataRow> Enviadados;

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
