using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class Liva : Basic.FrmClasse2
    {
        public Liva()
        {
            InitializeComponent();
        }
        private DataTable _ml;
        public  DataTable Dt = new DataTable();
        public DateTime DateTime2;
        public Diario Di { get; set; }
        public Dc Doc { get; set; }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAdoc.Text))
            {
                var dr = MsBox.Show($"Este documento será lançado na data: {dtData.dt1.Value.ToShortDateString()} \r\n Com número: {tbAdoc.Text}",DResult.YesNo);
                if (dr.DialogResult != DialogResult.Yes) return;
                var lcontstamp = SQL.GetValue("lcontstamp", "lcont", $"Apuraiva=1 and ano= {dtData.dt1.Value.Year} and mes = {dtData.dt1.Value.Month}");
                if (string.IsNullOrEmpty(lcontstamp))
                {
                    Bind();
                }
                else 
                {
                    var result = MsBox.Show($"já exite um apuramento no mês de: {dtData.dt1.Value.Month}/{dtData.dt1.Value.Year} \r\n Deseja Recriar o Movimento ?",DResult.YesNo);
                    if (result.DialogResult != DialogResult.Yes) return;
                    SQL.Apagar("lcont", lcontstamp.Trim());
                    Bind();
                }
            }
            else
            {
                MsBox.Show(@"Deve indicar o número do lançamento");
            }
        }
        private void Bind()
        {
            
            Lc.Adoc = tbAdoc.Text;
            Lc.Data = dtData.dt1.Value;
            Lc.Ano = dtData.dt1.Value.Year;
            Lc.Dia = dtData.dt1.Value.Day;
            Lc.Mes = dtData.dt1.Value.Month;
            Lc.Dilno = tbAdoc.Text.ToDecimal();
            Lc.Docnome = ucDoc.tb1.Text;
            Lc.Dinome = ucDiario.tb1.Text;
            Lc.Docno = ucDiario.Text2.ToDecimal();
            Lc.Debfin = tbDeb.tb1.Text.ToDecimal();
            Lc.Crefin = tbCred.tb1.Text.ToDecimal();
            Lc.Apuraiva = true;
            EF.Save(Lc);
           GravarFilhas(Lc.Lcontstamp);
           MsBox.Show(@"Apuramento lançado com sucesso");
        }

        private bool GravarFilhas(string p)
        {
            bool retorn;
            var data = (DataTable)dgvMl.DataSource;
            if (data == null) return false;
            var rt=SQL.Save(data, "ml", true, p, "lcont");
            retorn = rt.numero==1;
            return retorn;
        }

        private void Liva_Load(object sender, EventArgs e)
        {
            EditMode = true;
            ucDiario.Selecionado = "dino,descricao";
            ucDoc.Selecionado = "dcstamp,docnome";
            var str = $"SELECT dbo.func_GenNumber({Di.Dino},{dtData.dt1.Value.Month},{dtData.dt1.Value.Year})";
            var maximo = SQL.SQLExecScalar(str);
            tbNumero.tb1.Text = maximo.ToString();
            tbAdoc.Text = maximo.ToString();
            ucDoc.tb1.Text = Doc.Docnome;
            ucDoc.Text2 = Doc.Docno.ToString();
            ucDiario.tb1.Text = Di.Descricao;
            ucDiario.Text2 = Di.Dino.ToString();
            Lc = BL.Classes.Utilities.DoAddline<Lcont>();
            PolulateGrid();
            dtData.dt1.Value = new DateTime((int) Pbl.AnoContabil(), tbMes.Text2.ToInt32(), 1).LastDayOfMonth();
        }

        public Lcont Lc { get; set; }
        private void PolulateGrid()
        {

            _ml = SQL.GetGen2DT("select * from ml where 1=0");
            decimal cred = 0;
            decimal deb1 = 0;
            foreach (var r in Dt.AsEnumerable())
            {
                if (r["apura"].ToBool())
                {
                    var rw = _ml.NewRow();
                    rw["Mlstamp"] = Pbl.Stamp();
                    rw["Lcontstamp"] = Lc.Lcontstamp;
                    rw["conta"] = r["conta"];
                    rw["descricao"] = r["descricao"];
                    rw["cre"] = r["cre"];
                    rw["deb"] = r["deb"];
                    rw["descritivo"] = "AIVA";
                    if (r["deb"].ToString() != "")
                    {
                        deb1 = deb1 + r["deb"].ToDecimal();
                    }
                    if (r["cre"].ToString() != "")
                    {
                        cred = cred + r["cre"].ToDecimal();
                    }
                    _ml.Rows.Add(rw);
                }
                dgvMl.DataSource = null;
                dgvMl.AutoGenerateColumns = false;
                dgvMl.DataSource = _ml;
            }
        }
    }
}
