using DMZ.BL.Classes;
using DMZ.UI.Basic;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmRemoverFactura : FrmClasse2
    {
        public FrmRemoverFactura()
        {
            InitializeComponent();
        }

        private void FrmClasses2_Load(object sender, EventArgs e)
        {
 

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            var quer = $@"select Turmastamp,Clstamp,Cursostamp,descricao,Anosem,nome,
     convert(decimal, COUNT(*)) NurmeroRepeticoes from (select descricao=iif((select Usacademia from param)=1,isnull((select top  1 descricao from factl where Factstamp=ccstamp),descricao),descricao),nrdoc,data,valordoc,valorpreg,valorreg=valorpreg,ok,ccstamp,origem,oristamp,
		                            Moeda,Cambiousd,no,nome,Dias,ccusto,Clstamp,vencim,Rcladiant,
									Entidadebanc,Referencia,
									Turmastamp=iif(Rcladiant=1,(select Turmastamp from rcl
									where rclstamp=ccstamp),(select Turmastamp from fact
									where Factstamp=ccstamp)),
									Anosem=iif(Rcladiant=1,(select Anosem from rcl
									where rclstamp=ccstamp),(select Anosem from fact
									where Factstamp=ccstamp)),Cursostamp =iif(Rcladiant=1,(select Cursostamp from rcl where rclstamp=ccstamp),(select Cursostamp from fact where Factstamp=ccstamp))  from (
		                            select (LTRIM(RTRIM(cc.documento)) +'  '+Convert(varchar,cc.nrdoc)) as descricao,nrdoc=iif((select Montanumero from param)=1,
		                            Convert(char(15),(select (CodInterno +'/'+numero+'/'+Convert(char,YEAR(data))) nrdocc from fact where Factstamp=cc.ccstamp)),convert(char(12),cc.nrdoc)),
		                            cc.data,
		                            valordoc=iif(cc.Rcladiant=1,iif(moeda = dbo.MoedaNacional(),-1*credito,-1*creditom),iif(moeda = dbo.MoedaNacional(),debito,debitom)),
		                            valorpreg=(iif(cc.Rcladiant=1,iif(moeda = dbo.MoedaNacional(),-1*(credito-creditof),-1*(creditom-creditofm)),iif(moeda = dbo.MoedaNacional(),IIF(cc.origem='NC',debito+(-1*debitof),debito-debitof),IIF(cc.origem='NC',debitoM+(-1*debitofM),debitoM-debitofM)))),
		                            valorreg=0,
		                            0 as ok,cc.ccstamp,cc.origem,oristamp,debito,credito,cc.Cambiousd,cc.no,cc.nome,DATEDIFF(day,cc.data,getdate()) as Dias,cc.ccusto,moeda,Clstamp,vencim,cc.Rcladiant,Entidadebanc,Referencia
		                            from cc where cc.origem in ('FT','RCA','NC','ND') 
		                            group by documento,cc.nrdoc,cc.data,cc.ccstamp,cc.data,cc.credito,cc.debito,cc.creditom,cc.debitom,cc.creditofm,cc.creditof,cc.debitofm,
		                            debitof,cc.moeda,cc.origem,oristamp,cc.Cambiousd,cc.no,cc.nome,cc.ccusto,Moeda,Clstamp,vencim,cc.Rcladiant,Entidadebanc,Referencia)tmp1
		                            where valorpreg<>0 
									)temp	
									GROUP BY
    Turmastamp,Clstamp,Cursostamp,descricao,Anosem,nome

 HAVING 
    COUNT(*) > 1;";
            var dt = SQL.GetGen2DT(quer);
            tbTotal.Text="0";
            try
            {
                if (dt.HasRows())
                {

                    tbTotal.Text=dt.Sum("NurmeroRepeticoes").ToDecimal().ToString();
                }
            }
            catch (Exception ex)
            {
                //
            }
            gridUiAlunos.SetDataSource(dt);
        }

        private void btnRemoveFact_Click(object sender, EventArgs e)
        {
            var dt = gridUiAlunos.GetBindedTable();
            if (dt.HasRows())
            {
                try
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        try
                        {
                            var cursostamp = item["cursostamp"].ToString();
                            var Turmastamp = item["Turmastamp"].ToString();
                            var Clstamp = item["Clstamp"].ToString();
                            var Anosem = item["Anosem"].ToString();
                            var Descricao = item["Descricao"].ToString();
                            var quer = $@"delete 
from fact  WHERE FACTSTAMP IN (
select ccstamp from cc where ccstamp	in (
SELECT Factstamp FROM  Fact 
where Factstamp   in( 
select top (SELECT COUNT(*)-1 FROM (select 
nome=(select Nome from fact t where t.Factstamp =fl.Factstamp),
fl.descricao,fl.Factstamp,fl.Factlstamp  FROM  factl fl 
 where Factstamp in(SELECT 
    fl.Factstamp
FROM FACT F INNER JOIN  factl fl on f.Factstamp=fl.Factstamp 
 where Turmastamp='{Turmastamp}'  and Clstamp='{Clstamp}'
and Cursostamp='{cursostamp}'and Anosem='{Anosem}' 
) and fl.descricao='{Descricao}')TEMP
) 
fl.Factstamp  FROM  factl fl 
 where Factstamp in(SELECT 
    fl.Factstamp
FROM FACT F INNER JOIN  factl fl on f.Factstamp=fl.Factstamp 
 where Turmastamp='{Turmastamp}'  and Clstamp='{Clstamp}'
and Cursostamp='{cursostamp}'and Anosem='{Anosem}'  
) and fl.descricao='{Descricao}'  )) 
)";
                            SQL.SqlCmd(quer);
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }

                    }
                    MsBox.Show($"{Messagem.ParteInicial()}Todas facturas duplicadas foram removidas do sistema.");
                    btnProcurar_Click(sender,e);
                }
                catch (Exception ex)
                {

                    //throw;
                }
            }
            else
            {

                MsBox.Show($"{Messagem.ParteInicial()}Todas facturas duplicadas ja foram removidas do sistema.");
            }
        }
    }
}
