using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmAgruparmesas : Basic.FrmClasse2
    {
        public FrmAgruparmesas()
        {
            InitializeComponent();
        }

        public DataTable QryMV { get; private set; }
        public DataTable QryMF { get; private set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void tbProcuraMF_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridMesasF, QryMF, tbProcuraMF.Text);
        }

        private void FrmAgruparmesas_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            EditMode = true;
            QryMF = SQL.GetGen2DT("Select UPPER(nome) as nome,clstamp,cast(0 as bit) ok from cl where pos=1 order by Convert(decimal,no)");
            gridMesasF.SetDataSource(QryMF);
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageMF);
            btnProcessar.Visible = false;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            gridMesasF.Update();
            if (QryMF.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
            {              
                if (!Cliente.tb1.Text.IsNullOrEmpty())
                {
                    var dt = QryMF.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                    var uni = Utilities.DoAddline<Unimesa>();
                    uni.Clstamp = Cliente.Text2;
                    uni.Nome = Cliente.tb1.Text;
                    var xx = EF.Save(uni);
                    if (xx.ret>0)
                    {
                        var dt2 = SQL.Initialize<Unimesal>();
                        foreach (var r in dt.AsEnumerable())
                        {
                            var row = dt2.NewRow().Inicialize();
                            row["Descricao"] = r["nome"];
                            row["Messastamp"] = r["clstamp"];
                            row["Unimesastamp"] = uni.Unimesastamp;
                            row["Total"] = 0;
                            dt2.Rows.Add(row);
                        }
                        SQL.Save(dt2, "Unimesal",true, uni.Unimesastamp, "Unimesa");
                        Helper.Alert("Gravado com sucesso",Basic.Form_Alert.EnmType.Success);
                    }
                    else
                    {
                        MsBox.Show(xx.msg);
                    }
                }
                else
                {
                    MsBox.Show("Deve indicar a Mesa Virtual agrupadora");
                }
            }
            else
            {
                MsBox.Show("Deve indicar as mesas que deseja agrupar");
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
