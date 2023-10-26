using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
namespace DMZ.UI.UI
{
    public partial class FrmConsultacx : FrmClasse2
    {
        public FrmConsultacx()
        {
            InitializeComponent();
        }
        public decimal Codlocal { get; set; }
        public string Origem { get; set; }

        private DataTable _dt;
        private string condDatas;

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (_dt.HasRows())
            {
                _dt.Rows.Clear();
            }
            string Condicao = "";
            if (dmzEntreDatas1.checkBox1.Checked)
            {
                Condicao = $" and  CONVERT(date, Datamov) >= '{dmzEntreDatas1.dt1.Value.ToSqlDate()}' and CONVERT(date, Datamov)<= '{dmzEntreDatas1.dt2.Value.ToSqlDate()}'";
            }
            if (!cbSupervisor.cb1.Checked)
            {
                Condicao = $" {Condicao} and UsrLogin='{Pbl.Usr.Usrstamp}'";
            }
            if (!cbTodas.cb1.Checked)
            {
                if (!string.IsNullOrEmpty(comboBox1.tb1.Text))
                {
                    Condicao = $" {Condicao} and Contasstamp='{comboBox1.Text3.Trim()}'";
                }
            }
            BindGridMov(Condicao);
            //if (dtUsr.HasRows())
            //{
            //    foreach (var r in dtUsr.AsEnumerable())
            //    {
            //        condusr = $" and UsrLogin='{r[0].ToString().Trim()}'";
            //        caixausr=$" and qmc ='{r[0].ToString().Trim()}'";
            //        BindGridMov(dData1,dData2,condconta,caixausr,condusr,true);
            //    }
            //}
            //else
            //{
            //    BindGridMov(dData1,dData2,condconta,caixausr,condusr);
            //}
        }

        private void BindGridMov( string cond)
        {
            var qry = $@"select local Contatesoura,Datamov,Nrdoc numero,entrada,saida,Estado=iif(Fechado=1,'Fechado','Aberto'), descricao nome,Documento,Contasstamp,Total=0,(select nome from  usr where usrstamp =mvt.UsrLogin) nomeUsr
					from mvt where origem in ('ABERTURA','POSRCL','EFM','RF') {cond} order by Contatesoura,datamov,Origem";

            _dt = SQL.GetGenDT(qry);
            if (_dt.HasRows())
            {
                var dr1 = _dt.NewRow();
                dr1["entrada"] = _dt.Sum("entrada");
                dr1["saida"] = _dt.Sum("saida");
                dr1["Total"] = _dt.Sum("entrada").ToDecimal()-_dt.Sum("saida").ToDecimal();
                dr1["Nome"] = "";
                dr1["Contatesoura"] = "TOTAL";
                dr1["Datamov"] = dmzEntreDatas1.dt1.Value;
                _dt.Rows.InsertAt(dr1, _dt.Rows.Count);
                gridUi1.SetDataSource(_dt);  
            }           
        }

        private void FrmConsultacx_Load(object sender, EventArgs e)
        {
            EditMode = true;
            comboBox2.tb1.Text=Pbl.Usr.Nome;
            comboBox2.Text2 = Pbl.Usr.Login;
            cbSupervisor.Update(Pbl.Usr.Supervisor);
            if (!Pbl.Usr.Supervisor && !Pbl.Usr.Usradmin)
            {
                comboBox2.btnProc.Enabled= false;
                comboBox2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrint.ShowMenuStrip(button1);
        }

        private void comboBox2_RefreshControls()
        {
            btnProcessar_Click(this,EventArgs.Empty);
        }

        private void comboBox1_GetDataEvent()
        {
//            //select descpos as Descricao,Cast(0 as decimal) as valor,conta, cx,conta as contas,Contasstamp,Codtz
//            var campos = new[]
//{
//                        "Descricao", "conta", "Contasstamp"
//                    };
            DataTable DtContas = Pbl.DtContas.DefaultView.ToTable(true, "Descricao", "conta", "Contasstamp");
            comboBox1.SqlDt = DtContas;
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var xml = SQL.GetXmlReport("Caixa");
            Imprimir2("Caixa", xml);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var xml = SQL.GetXmlReport("CaixaSPOS");
            Imprimir2("CaixaSPOS", xml);
        }

        private void Imprimir2(string ReportName,string xml)
        {
            var dt = gridUi1.DataSource as DataTable;
            if (dt?.Rows.Count > 0)
            {
                var data1 = new DateTime(dmzEntreDatas1.dt1.Value.Year, dmzEntreDatas1.dt1.Value.Month, dmzEntreDatas1.dt1.Value.Day);
                var data2 = new DateTime(dmzEntreDatas1.dt2.Value.Year, dmzEntreDatas1.dt2.Value.Month, dmzEntreDatas1.dt2.Value.Day);
                var filtro = $"Data(s): {data1.ToShortDateString()} - {data2.ToShortDateString()}";
               
                DS ds = new DS();
                var ret = Imprimir.FillData(null, dt, null, ds.DMZ, null);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", ReportName, "Caixa", this, xml, false, ds, filtro, "");
            }
            else
            {
                MsBox.Show("Nada a imprimir!");
            }
        }
    }
}
