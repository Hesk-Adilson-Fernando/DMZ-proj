using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI.Contabil
{
    public partial class PgcExtrato : Basic.FrmClasse2
    {
        public PgcExtrato()
        {
            InitializeComponent();
        }
        public string Conta { get; set; }
        public string Descritivo { get; set; }

        private DataTable dt;
        private string filtro;

        private void PgcExtrato_Load(object sender, EventArgs e)
        {
            
            label1.Text = $@"Extrato da Conta: {Conta}";
            txtDescricao.Text =  $@"{Conta} - {Descritivo}";

            nrAno.Value=Pbl.AnoContabil();
            Data1.Value = new DateTime((int)nrAno.Value,Pbl.SqlDate.Month,Pbl.SqlDate.Day);
            Data2.Value = new DateTime((int)nrAno.Value, Pbl.SqlDate.Month, Pbl.SqlDate.Day);

            dt = SQL.GetGen2DT(@"select conta,descricao,descritivo,deb,cre,convert(char(15),ml.data,104) as data,Lcont.dinome,
	            Lcont.dilno,cast(-2 as numeric) as ordem,Pgcstamp
	            from ml (nolock) inner join lcont on ml.Lcontstamp=Lcont.Lcontstamp where 1=0");
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            filtro="";
            if (!cbTodasContas.cb1.Checked)
            {
                var qry = GetSQLQuerry(Conta);
                dt = SQL.GetGen2DT(qry);
                if (dt?.Rows.Count <= 0) return;
                filtro = $"Ano Contabilístico: {nrAno.Value}\r\nDatas entre: {Data1.Value.ToFormatoDiaMesAno()} - {Data2.Value.ToFormatoDiaMesAno()} ";
                
            }
            else
            {
                var contas = SQL.GetGen2DT("select Pgcstamp from pgc where integracao=0 and and ano =(select ano from param)");
                if (contas.HasRows())
                {
                    foreach (var item in contas.AsEnumerable())
                    {
                        if (item != null)
                        {
                           // sel
                        }
                    }
                }
            }
            gridUi1.SetDataSource(dt);
        }

        private string GetSQLQuerry(string conta)
        {
            return $@"
	            select conta,isnull(iif(GROUPING(descricao)=1,iif(GROUPING(conta)=1,'TOTAL GERAL','SUBTOTAL'),descricao),'') as descricao,isnull(descritivo,'') as descritivo,sum(deb) as deb,sum(cre) as cre,isnull(data,'') as data,isnull(dinome,'') as dinome,
	            isnull(convert(char,dilno),'') as dilno,ordem, saldo =(iif(GROUPING(conta)=1,sum(deb)-sum(cre),0)) from (
	            select conta,descricao='SALDO ANTERIOR',descritivo='',sum(deb) deb,sum(cre) cre,data='',dinome='',dilno=0,cast(-3 as numeric) as ordem,Pgcstamp
	            from ml (nolock) where ml.Pgcstamp = '{conta}'  and convert(date,ml.data)<'{Data1.Value.ToSqlDate()}' group by conta 
	            union all 
	            select conta,descricao,descritivo,deb,cre,convert(char(15),ml.data,104) as data,Lcont.dinome,
	            Lcont.dilno,cast(-2 as numeric) as ordem,Pgcstamp
	            from ml (nolock) inner join lcont on ml.Lcontstamp=Lcont.Lcontstamp where ml.Pgcstamp = '{conta}' and convert(date,ml.data)>='{Data1.Value.ToSqlDate()}' and convert(date,ml.data)<='{Data2.Value.ToSqlDate()}'	
	            group by conta,lcont.dilno,descricao,descritivo,deb,cre, ml.data,lcont.dinome)tmp1 
	            group by rollup ((conta),(dilno,descricao,descritivo,deb,cre, data,dinome,ordem)) ";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dt = gridUi1.DataSource as DataTable;
            if (dt.HasRows())
            {
                //var f = new FrmReport
                //{
                //    Origem = "CT",
                //    Dt = dt,
                //    TabelaName = "DMZ",
                //    ReportName = "ExtractoPgc",
                //    Filtro =filtro,
                //    CTituloRelatorio = $"extrato da conta: {txtDescricao.tb1.Text}".ToUpper()
                //};
                //f.ShowForm(this);

                DS ds = new DS();
                var ret = Imprimir.FillData(null, dt, null, ds.DMZ,null);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "ExtractoPgc", "CT", this, "", true, ds, filtro, $"extrato da conta: {txtDescricao.tb1.Text}".ToUpper());
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"Não tem nada para imprimir");
            }
        }
    }
}
