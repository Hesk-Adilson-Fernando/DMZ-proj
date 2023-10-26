using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Properties;
using DMZ.UI.Reports;
using System;
using System.Data;
using System.Linq;
using Util = DMZ.UI.Generic.Util;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmCartimp : Basic.FrmClasse2
    {
        private DataTable dt;

        public FrmCartimp()
        {
            InitializeComponent();
        }

        private void FrmCartimp_Load(object sender, EventArgs e)
        {
            var xx = @"select no,clcart.codigo,nome, curso,clcart.data,clcart.datavenc,imagem,Codigobarra,codigoqr,cast(0 as bit) sel  from cl inner
                                join clcart on cl.Clstamp = clcart.clstamp";
            dt = SQL.GetGen2DT($@" {xx} where 1=0");
            var dt1 = SQL.GetGen2DT($@" {xx} where Aluno=1");
            if (dt1.HasRows())
            {
                var imgemArray = Util.GetImagem(Resources.Picture_64px, false);
                foreach (var item in dt1.AsEnumerable())
                {
                    if (item !=null)
                    {
                        var xxxxx = (byte[])item["imagem"];
                       //var x = ; // true
                        if (!xxxxx.SequenceEqual(imgemArray))
                        {
                            var r = dt.NewRow();
                            foreach (DataColumn col in dt.Columns)
                            {
                                r[col.ColumnName] = item[col.ColumnName];
                            }
                            dt.Rows.Add(r);
                        }
                    }
                }
            }
            gridUiAlunos.SetDataSource(dt);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            DS ds = new DS();
            var xml = SQL.GetXmlReport("CartList");
            if (dt.HasRows())
            {
                dt= dt.AsEnumerable().Where(s => s.Field<bool>("sel").Equals(true)).CopyToDataTable();
                var ret = Imprimir.FillData(null, dt, null, ds.Cartlist, null);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "CartList", "", this, xml, true, ds, "", ""); 
            }
        }
    }
}
