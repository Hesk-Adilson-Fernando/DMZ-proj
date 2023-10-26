using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmCheckCC : DMZ.UI.Basic.FrmClasse2
    {
        public FrmCheckCC()
        {
            InitializeComponent();
        }

        private void dmzProcess_Load(object sender, EventArgs e)
        {

        }

        public string Qry { get; set; }
        public DataTable Dt { get; set; }
        public string Origem { get; internal set; }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!dmzProcess.tb1.Text.IsNullOrEmpty())
            {
                var cond = "";
                if (dmzEntreDatas1.checkBox1.Checked)
                {
                    cond = $" and convert(data)>='{dmzEntreDatas1.dt1.Value.ToSqlDate()}' and convert(data)<='{dmzEntreDatas1.dt2.Value.ToSqlDate()}'";
                }
                if (Origem=="CL")
                {
                    Qry = $@"select cast(0 as bit) ok, (origem+''+Convert(char,nrdoc)) as documento,debito,debitof,nome,ccstamp,Clstamp,data,origem 
                            from cc where origem in ('FT','NC','ND')
                                and (abs(debito)-abs(debitof))>0 and Clstamp='{dmzProcess.Text2.Trim()}'  {cond}  order by origem,nrdoc";
                }
                else
                {
                    Qry = $@"select cast(0 as bit) ok, (origem+''+Convert(char,nrdoc)) as documento,debito,debitof,nome,fccstamp,fncstamp,data,origem 
                            from fcc where origem in ('FTF','NC','ND')
                                and (abs(debito)-abs(debitof))>0 and fncstamp='{dmzProcess.Text2.Trim()}'  {cond}  order by origem,nrdoc";
                }
                Dt = SQL.GetGen2DT(Qry);
                if (Dt.HasRows())
                {
                    GridProcess.SetDataSource(Dt);
                }
                else
                {
                    MsBox.Show("A procura não encontrou resultados! ");
                }                
            }
            else
            {
                MsBox.Show("Deve indicar o cliente ");
            }
        }

        private void cbDefault1_Load(object sender, EventArgs e)
        {

        }

        private void cbDefault1_CheckedChangeds()
        {
            GridProcess.CheckUncheckAll("ok", cbDefault1.cb1.Checked);
        }

        private void btnAddprocess_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (Dt.HasRows())
            {
                GridProcess.Update();
                var dt = GridProcess.GetBindedTable();
                if (dt.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
                {
                    dt = dt.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                    if (dt.HasRows())
                    {
                        Helper.DoProgressProcess(dt, RecebeDados);
                    }
                }
            }
        }

        private void RecebeDados(DataRow dr, bool fim)
        {
            if (dr !=null)
            {
                switch (Origem)
                {
                    case"CL":
                        var valor = SQL.GetField($@"select isnull(sum(Valorreg),0) Valorreg from rcll where Ccstamp='{dr["Ccstamp"].ToString().Trim()}'").ToDecimal();
                        if (valor > dr["debitof"].ToDecimal())
                        {
                            if (valor <= dr["debito"].ToDecimal())
                            {
                                SQL.SqlCmd($"update cc set debitof={valor} where ccstamp='{dr["Ccstamp"].ToString().Trim()}' and origem='{dr["origem"].ToString().Trim()}'");
                            }
                        }
                        else if (dr["origem"].ToString().Equals("NC"))
                        {
                            if (Math.Abs(valor) <= Math.Abs(dr["debito"].ToDecimal()))
                            {
                                SQL.SqlCmd($"update cc set debitof={valor} where ccstamp='{dr["Ccstamp"].ToString().Trim()}' and origem='{dr["origem"].ToString().Trim()}'");
                            }
                        }
                        break;
                    case "FNC":
                        var Valorreg = SQL.GetField($@"select isnull(sum(Valorreg),0) Valorreg from pgfl where fCcstamp='{dr["fCcstamp"].ToString().Trim()}'").ToDecimal();
                        if (Valorreg > dr["debitof"].ToDecimal())
                        {
                            if (Valorreg <= dr["debito"].ToDecimal())
                            {
                                SQL.SqlCmd($"update fcc set debitof={Valorreg} where fccstamp='{dr["fCcstamp"].ToString().Trim()}' and origem='{dr["origem"].ToString().Trim()}'");
                            }
                        }
                        else if (dr["origem"].ToString().Equals("NC"))
                        {
                            if (Math.Abs(Valorreg) <= Math.Abs(dr["debito"].ToDecimal()))
                            {
                                SQL.SqlCmd($"update fcc set debitof={Valorreg} where fccstamp='{dr["fCcstamp"].ToString().Trim()}' and origem='{dr["origem"].ToString().Trim()}'");
                            }
                        }
                        break;
                }
            }
        }
    }
}
