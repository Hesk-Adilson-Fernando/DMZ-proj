using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI.Contabil
{
    public partial class Lc : Basic.FrmClasse2
    {
        public Lc()
        {
            InitializeComponent();
        }
        private DataTable _dt, _dtMl, _dtPrint;
        private void Lc_Load(object sender, EventArgs e)
        {
            var data = Pbl.DataContabil();
            dtDataInc.Dia.Value = data.Day;
            dtDataInc.Mes.Value = data.Month;
            dtDataInc.Ano.Value = data.Year;
            dtDatafin.Dia.Value = data.Day;
            dtDatafin.Mes.Value = data.Month;
            dtDatafin.Ano.Value = data.Year;
            EditMode = true;
        }

        private void dgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocumentos.CurrentRow == null) return;
            var cr=dgvDocumentos.CurrentRow;
            BindFilhas(cr.Cells["stamp"].Value.ToString());
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Processar();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dmzMenuLinhas.ShowMenuStrip(btnPrint);
        }

        private void toolStripExtrato_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dgvDocumentos.CurrentRow == null) return;
            CLocalStamp = dgvDocumentos.CurrentRow.Cells["stamp"].Value.ToString();
            if (string.IsNullOrEmpty(CLocalStamp)) return;
            //var p = new FrmReport
            //{
            //    Printstamp = CLocalStamp,
            //    Origem = "LCont",
            //    ReportName = "LancamCont"
            //};
            //p.ShowForm(this, true);

            //DS ds = new DS();
            //var ret = Imprimir.FillData(null, _armazeml, null, ds.DMZ, null);
            //Imprimir.CallForm(ret.dtPrint, ret.fp, "", false, "", "", "LCont", "RLT", this, "", true, ds, "LISTA DE PRODUTOS EXISTENTES", "TODOS ARMAZENS");
            //Cursor = Cursors.Default;
        }

        private void Processar()
        {
            string filtro;
            //l.dia between {dtDataInc.Dia.Value} and {dtDatafin.Dia.Value} and
            filtro = $" where  l.mes >= {dtDataInc.Mes.Value} and l.mes <={dtDatafin.Mes.Value} and l.ano={dtDataInc.Ano.Value}";
            if(!string.IsNullOrEmpty(ucDiario.tb1.Text))
            {
                filtro += $" and l.dino= {ucDiario.Text2}";
            }
            if (cbDebDifCre.cb1.Checked)
            {
                filtro += " and l.debfin<>l.crefin";
            }
            var qry = $"select * from Lcont l {filtro} order by data desc ";
            _dt = SQL.GetGen2DT(qry);
            if (!_dt.HasRows()) return;
            dgvDocumentos.SetDataSource(_dt);
            tbDeb.tb1.Text = _dt.Sum("debfin").ToString().SetMask();// $@"{decimal.Parse(_dt.AsEnumerable().Sum(x => x.Field<decimal>("debfin")).ToString(CultureInfo.InvariantCulture)):N}";
            tbCred.tb1.Text = _dt.Sum("crefin").ToString().SetMask();// $@"{decimal.Parse(_dt.AsEnumerable().Sum(x => x.Field<decimal>("crefin")).ToString(CultureInfo.InvariantCulture)):N}";
            if (dgvDocumentos.CurrentRow != null)
            {
                var cr = dgvDocumentos.CurrentRow;
                BindFilhas(cr.Cells["stamp"].Value.ToString());
            }
            else
            {
                dgvMl.AutoGenerateColumns = false;
                dgvMl.DataSource = null;
                tbDebLinhas.tb1.Text = "";
                tbCredLinhas.tb1.Text = "";
            }
        }
        private void BindFilhas(string p)
        {
            _dtMl = SQL.GetGen2DT($"select * from ml where ltrim(rtrim(lcontstamp))= '{p.Trim()}' order by conta");
            if (!_dtMl.HasRows()) return;
            dgvMl.SetDataSource(_dtMl);
            tbDebLinhas.tb1.Text = _dtMl.Sum("deb").ToString().SetMask(); 
            tbCredLinhas.tb1.Text = _dtMl.Sum("cre").ToString().SetMask();
        }
    }
}
