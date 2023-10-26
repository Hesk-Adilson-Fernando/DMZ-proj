using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;

namespace DMZ.UI.UI
{
    public partial class FrmCurvaAbc : Basic.FrmClasse2
    {
        public FrmCurvaAbc()
        {
            InitializeComponent();
        }

        private void FrmCurvaABC_Load(object sender, EventArgs e)
        {
            tbA.Text = @"80";
            tbB.Text = @"90";
            tbC.Text = @"100";
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            var qry = @"select * from (
                                select factl.descricao, sum(totall) Vendido,Cast(0 as decimal ) perc,Cast(0 as decimal ) percac,classific='',ordem=1  from factl join st on Factl.ref=st.Referenc where st.Servico=0
                                group by factl.descricao 
                                union all 
                                select descricao ='Total', sum(totall) Vendido,Cast(0 as decimal ) perc,Cast(0 as decimal ) percac,classific='',ordem=2  from factl join st on Factl.ref=st.Referenc where st.Servico=0)
                                tmp1 order by ordem, Vendido desc";
            var dt = SQL.GetGen2DT(qry);
            if (!(dt?.Rows.Count > 0)) return;
            var rw = dt.Select().Where(x => x.Field<string>("descricao").Trim().Equals("Total")).FirstOrDefault();
            if (rw == null) return;
            var total = rw["Vendido"].ToDecimal();
            var i = 0;
            foreach (var r in dt.AsEnumerable())
            {
                if (r["descricao"].ToString().Trim().Equals("Total")) continue;
                r["perc"] = r["Vendido"].ToDecimal() * 100 / total;
                if (i==0)
                {
                    r["percac"] = r["perc"].ToDecimal(); 
                }
                else
                {
                    r["percac"] = r["perc"].ToDecimal()+dt.Rows[i-1]["percac"].ToDecimal();      
                }

                if (r["percac"].ToDecimal()<=tbA.Text.ToDecimal())
                {
                    r["classific"] = "A";
                }
                else if (r["percac"].ToDecimal()<=tbB.Text.ToDecimal())
                {
                    r["classific"] = "B";
                }
                else
                {
                    r["classific"] = "C";
                }
                i++;
            }
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = dt;

        }
    }
}
