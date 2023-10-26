using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.PRC
{
    public partial class FrmFncPrazo : FrmClasse2
    {
        public FrmFncPrazo()
        {
            InitializeComponent();
        }
        private DataTable _dtGrid;
        public Action<DataTable> SendData;
        public string Pjstamp { get; set; }
        public string  NoFnc { get; set; }
        public void BindiGrid(DataTable dt)
        {
            _dtGrid = dt;
            GridProcess.DataSource = null;
            GridProcess.AutoIncrimento = false;
            GridProcess.AutoGenerateColumns = false;
            GridProcess.DataSource = dt;
        }
        private void GridProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var namee = GridProcess.CurrentCell.OwningColumn.Name.ToLower();
            if (namee.Equals("status"))
            {
                if (GridProcess.CurrentRow != null)
                {
                    NoFnc = GridProcess.CurrentRow.Cells["no"].Value.ToString();
                }
                var qry = $"select No, Nome, Ref, Descricao, quant, PrazoEntrega  " +
                          $"from(select quant = isnull((select top 1 iif(pl.Quant >= fl.quant," +
                          $" pl.Quant - fl.quant, pl.quant) from faccl fl join facc " +
                          $"fc on fl.Faccstamp = fc.Faccstamp where" +
                          $" fl.Ref = pl.Ref and Pjstamp = '{Pjstamp}'), pl.Quant)," +
                          $" Descricao, pl.Ref, pl.Nome, pl.Preco, pl.Procurmlstamp," +
                          $" pl.Txiva, pl.Tabiva, pl.Perdesc, pl.Descontol, pl.Ivainc," +
                          $" pl.Factura,pl.No,Convert(date, pl.PrazoEntrega) PrazoEntrega " +
                          $"from Procurml pl where Procurmstamp = '{Pjstamp}' )" +
                          $" temp WHERE  " +
                          //$" temp WHERE quant > 0 and " +
                          $" PrazoEntrega<GETDATE() and No='{NoFnc}' ";
                var dtst = SQL.GetGenDT(qry);
                var dc = new DataColumn { DataType = typeof(bool), ColumnName = "ok" };
                dtst.Columns.Add(dc);
                var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "facturado" };
                dtst.Columns.Add(dc2);
                foreach (var r in dtst.AsEnumerable())
                {
                    r["ok"] = false;
                    r["facturado"] = true;
                }
                var bw = new FrmAddArtigos1
                {
                   // SendData = SendData
                };
                bw.Origem = 1;
                bw.BindiGrid(dtst);
                bw.ShowForm(this, true);

            }
        }
    }
}
