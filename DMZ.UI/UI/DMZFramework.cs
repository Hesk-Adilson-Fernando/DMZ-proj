using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Agent;
namespace DMZ.UI.UI
{
    public partial class DmzFramework : FrmClasse2
    {
        public DmzFramework()
        {
            InitializeComponent();
        }
        private Server _myServer;
        ServerConnection _cnn;
        private string _connectionString;
        private string _dataBase;
        private void DMZFramework_Load(object sender, EventArgs e)
        {

        }
        private void ServerInitiation()
        {
            var _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _connectionString=_config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(_connectionString);
            _dataBase = builder.InitialCatalog.Trim();
            var tmpConn = new SqlConnection
            {
                ConnectionString = $"SERVER = {builder.DataSource.Trim()}; DATABASE = master; User ID = {builder.UserID.Trim()}; Password ={builder.Password.Trim()} "
            };
            _cnn = new ServerConnection(tmpConn.ConnectionString);
            _cnn.Connect();
            _myServer = new Server(_cnn);
        }
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (cbQuerry.cb1.Checked)
            {
                if (!string.IsNullOrEmpty(tbScript.Text))
                {
                    var dt = SQL.GetGen2DT(tbScript.Text);
                    gridUi1.SetDataSource(dt,true);
                }
            }

            if (cbSqlCmd.cb1.Checked)
            {
                if (string.IsNullOrEmpty(tbScript.Text)) return;
                var result = SQL.SqlCmd(tbScript.Text);
                if (result==1)
                {
                    MsBox.Show("Executado com sucesso!");
                }
            }
            if (cbSP.cb1.Checked)
            {
                ServerInitiation();
                var mydb = _myServer.Databases[_dataBase];
                sp = mydb.StoredProcedures[tbSPNome.Text];
                if (!string.IsNullOrEmpty(tbSPNome.Text))
                {
                    if (cbDelSP.cb1.Checked)
                    {
                        if (sp!=null)
                        {
                            sp.Drop();
                            MsBox.Show("Eliminado com sucesso");
                        }
                        else
                        {
                            MsBox.Show("A Stored Procedure não foi encontrada!");    
                        }
                    }
                    if (cbAddSP.cb1.Checked)
                    {
                        if (sp==null)
                        {
                            sp = new StoredProcedure(mydb, tbSPNome.Text);
                        }
                        sp.TextBody = tbScript.Text;
                        sp.TextMode = false;
                        sp.AnsiNullsStatus = false;
                        if (!cbAlterSP.cb1.Checked)
                        {
                            sp.QuotedIdentifierStatus = false;
                            if (gridUi2.Rows.Count > 0)
                            {
                                foreach (DataGridViewRow r in gridUi2.Rows)
                                {
                                    if (r == null) continue;
                                    DataType dataType = null;
                                    var tamanho = r.Cells[2].Value.ToString().ToInt32();
                                    var casasdecimais = r.Cells[3].Value.ToString().ToInt32();
                                    switch (r.Cells[1].Value.ToString().ToLower())
                                    {
                                        case "int":
                                            dataType = DataType.Int;
                                            break;
                                        case "datetime":
                                            dataType = DataType.DateTime;
                                            break;
                                        case "char":
                                            dataType = DataType.Char(tamanho);
                                            break;
                                        case "bit":
                                            dataType = DataType.Bit;
                                            break;
                                        case "numeric":
                                            dataType = DataType.Numeric(tamanho, casasdecimais == 0 ? 1 : casasdecimais);
                                            break;
                                    }
                                    var param = new StoredProcedureParameter(sp, $"@{r.Cells[0].Value.ToString().Trim()}", dataType);
                                    sp.Parameters.Add(param);
                                }
                            }
                            sp.Create();
                        }
                        else
                        {
                            //Modify a property and run the Alter method to make the change on the instance of SQL Server.   
                            sp.QuotedIdentifierStatus = true;  
                            sp.Alter();  
                        }

                        MsBox.Show(cbAlterSP.cb1.Checked?"Alterado com sucesso": "Criado com sucesso");
                    }

                    if (cbScriptSP.cb1.Checked)
                    {
                        if (sp != null)
                        {
                            tbScript.Text = sp.TextBody;
                            param = sp.Parameters;
                            if (param != null)
                            {
                                foreach (StoredProcedureParameter p in param)
                                {
                                    gridUi2.Rows.Add(p.Name, p.DataType,p.DataType.IsNumericType?p.DataType.NumericPrecision:p.DataType.MaximumLength,p.DataType.NumericScale);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MsBox.Show("Deve indicar o nome do SP");
                }
            }

            if (cbTrigger.cb1.Checked)
            {
                ServerInitiation();
                var mydb = _myServer.Databases[_dataBase];
                var mytab = mydb.Tables[tbTabela.Text.Trim()];
                if (cbDelTrigger.cb1.Checked)
                {
                    if (!string.IsNullOrEmpty(tbTabela.Text))
                    {
                        if (!string.IsNullOrEmpty(tbNomeTrigger.Text))
                        {
                            var tr= _myServer.Databases[_dataBase].Tables[tbTabela.Text.Trim()].Triggers[tbNomeTrigger.Text.Trim()];
                            tr.Drop();
                            MsBox.Show("Eliminado com sucesso");
                        }
                        else
                        {
                            MsBox.Show("Deve indicar o nome do trigger"); 
                        }
                    }
                    else
                    {
                        MsBox.Show("Deve indicar a tabela!..");
                    }
                }
                if (cbAddTrigger.cb1.Checked)
                {
                    if (!string.IsNullOrEmpty(tbNomeTrigger.Text))
                    {
                        if (!string.IsNullOrEmpty(tbScript.Text))
                        {
                            if (!string.IsNullOrEmpty(tbTabela.Text.Trim()))
                            {
                                var tr = new Trigger(mytab, tbNomeTrigger.Text)
                                {
                                    TextMode = false,
                                    Insert = true,
                                    Update = true,
                                    InsertOrder = ActivationOrder.First,
                                    TextBody = tbScript.Text,
                                    ImplementationType = ImplementationType.TransactSql,
                                    Name = tbNomeTrigger.Text
                                };
                                tr.Create();
                                MsBox.Show("Criado com sucesso");
                            }
                            else
                            {
                                MsBox.Show("Deve indicar a tabela ");    
                            }
                        }
                        else
                        {
                            MsBox.Show("Deve indicar o corpo do trigger");      
                        }
                    }
                    else
                    {
                        MsBox.Show("Deve indicar o nome do trigger");    
                    }
                }

                if (cbViewTrigger.cb1.Checked)
                {
                    if (!string.IsNullOrEmpty(tbTabela.Text))
                    {
                        if (!string.IsNullOrEmpty(tbNomeTrigger.Text))
                        {
                            var tr= _myServer.Databases[_dataBase].Tables[tbTabela.Text.Trim()].Triggers[tbNomeTrigger.Text.Trim()];
                            tbScript.Text = tr.TextBody;
                        }
                        else
                        {
                            MsBox.Show("Deve indicar o nome do trigger"); 
                        }
                    }
                    else
                    {
                        MsBox.Show("Deve indicar a tabela!..");
                    }  
                }
            }
        }

        public StoredProcedure sp { get; set; }

        public StoredProcedureParameterCollection param { get; set; }
        public string DtUsrModulos, _dtUsrModulos ;

        private void button1_Click(object sender, EventArgs e)
        {
            gridUi2.Rows.Add("", "", 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbScript.Text = "";
        }

        private void btnAutoProduto_Click(object sender, EventArgs e)
        {
            var f = @"Create function UDF_ExtractNumbers
                        (  
                          -- Input is alphanumeric string
                          @input varchar(255)  
                        )  
                        -- Returns numbers as a string
                        Returns varchar(255)  
                        As  
                        Begin  
                          -- Returns the index of a character that is not a number
                          -- If the specified pattern is not found, ZERO is returned
                          Declare @alphabetIndex int = Patindex('%[^0-9]%', @input)  
                          Begin  
                            While @alphabetIndex > 0  
                            Begin  
                              -- In the input string (@input) at the position (@alphabetIndex) 
	                          -- where we have a non-numeric chracter, replace that 1
	                          -- character with an empty string ('')
	                          Set @input = Stuff(@input, @alphabetIndex, 1, '' )
	                          -- Find the next non-numeric character and repeat the above step
	                          -- until all non-numeric characters are replaced with an empty string
                              Set @alphabetIndex = Patindex('%[^0-9]%', @input )  
                            End  
                          End  
                          Return @input
                        End";
            SQL.SqlCmd(f);
            MsBox.Show("Processo executado com sucesso");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnTriggerRcll_Click(object sender, EventArgs e)
        {
            var f = @"
                    
                    ALTER TRIGGER [dbo].[tgRCLLCC] 
                       ON  [dbo].[RCLL]
                       AFTER INSERT,UPDATE
                    AS 
                    BEGIN
	                    DECLARE
	                    @Cancelado bit,
	                    @Rcladiant bit,
	                    @pago numeric
	                    Select @Cancelado=inserted.anulado,@Rcladiant=inserted.Rcladiant,@pago=inserted.valorreg from inserted join rcl on inserted.Rclstamp=rcl.Rclstamp
	                    if @Rcladiant=0
		                    begin 
		                    if @pago>0
			                    begin 
				                    update cc set debitof=debitof+inserted.valorreg,debitofm=debitofm+inserted.mvalorreg from inserted where inserted.Ccstamp=cc.ccstamp
			                    end 
			                    else
			                    begin
			                        --update cc set debitof=debitof+inserted.valorreg,debitofm=debitofm+inserted.mvalorreg from inserted where inserted.Ccstamp=cc.ccstamp
				                    update cc set debitof=debitof+(-1*inserted.valorreg),debitofm=debitofm+(-1*inserted.mvalorreg) from inserted where inserted.Ccstamp=cc.ccstamp
			                    end 
		                    end
	                    else 
		                    begin
		                    update cc set creditof=creditof+(-1*inserted.valorreg),creditofm=creditofm+(-1*inserted.mvalorreg) from inserted where inserted.Ccstamp=cc.ccstamp
		                    end 
	                    if @Cancelado=1
		                    begin 
			                    if @Rcladiant=0
			                    begin
				                    update cc set debitof = debitof-inserted.valorreg from inserted where inserted.Ccstamp=cc.ccstamp
			                    end 
			                    else 
			                    begin 
				                    update cc set creditof = creditof-(-1*inserted.valorreg) from inserted where inserted.Ccstamp=cc.ccstamp
			                    end 
		                    end
                    END
                    ";
            SQL.SqlCmd(f);
            MsBox.Show("Processo executado com sucesso");
        }

        private void btnClCCF_Click(object sender, EventArgs e)
        {
            var f = @"
                    ALTER  FUNCTION [dbo].[ClCCF]()
                            RETURNS TABLE 
                            AS
                            RETURN 
                            (
		                            select descricao=iif((select Usacademia from param)=1,isnull((select top  1 descricao from factl where Factstamp=ccstamp),descricao),descricao),nrdoc,data,valordoc,valorpreg,valorreg=valorpreg,ok,ccstamp,origem,oristamp,
		                            Moeda,Cambiousd,no,nome,Dias,ccusto,Clstamp,vencim,Rcladiant,Entidadebanc,Referencia,Turmastamp=iif(Rcladiant=1,(select Turmastamp from rcl where rclstamp=ccstamp),(select Turmastamp from fact where Factstamp=ccstamp)),Cursostamp =iif(Rcladiant=1,(select Cursostamp from rcl where rclstamp=ccstamp),(select Cursostamp from fact where Factstamp=ccstamp))  from (
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
                            )
                    ";
            Executar(f);
        }

        private void Executar(string f)
        {
            tbScript.Text = f;
            SQL.SqlCmd(f);
            MsBox.Show("Processo executado com sucesso");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var f = @"

                    ALTER TRIGGER [dbo].[tgPECC] 
                       ON  [dbo].[Prc] AFTER INSERT,UPDATE
                    AS 
                    BEGIN
	                    DECLARE
	                    @Numero decimal(5,0),@Linhatotal bit,@Peccstamp varchar(30)

	                    Select @Linhatotal=Linhatotal,@Numero=Codigo,@Peccstamp=Prcstamp from inserted join Proces on inserted.Processtamp=Proces.Processtamp

	                    if @Linhatotal=1
	                    begin 
	                    IF NOT EXISTS (Select Peccstamp FROM Pecc where Peccstamp=@Peccstamp)
	                    Begin
		                    INSERT INTO [dbo].[Pecc]([Peccstamp],[Origem],[Oristamp],[Nrdoc],[No],[Nome],[Data],[Vencim],[Debito],[Debitom],[Debitof],[Debitofm]
                               ,[Credito],[Creditom],[Creditof],[Creditofm],[Documento],[Moeda],[Saldo],[Codmov],[Prcstamp],[Perclstamp],[Ccusto],[Numinterno]
                               ,[Estabno],[Estabnome],[Rcladiant],Pestamp)

		                    Select Prcstamp,origem='PRC',Processtamp,@Numero,no,nome,data,data,TotalLiquido,0,0,0,0,
		                    0,0,0,documento='PROCES'+ Convert(varchar,@Numero)+'/'+Convert(varchar,Year(data)),Moeda,saldo=0,0,Prcstamp,null,Ccusto,'',0,'',0,Pestamp
		                    from inserted 
	                    End
 
                    END
                    end

                                    ";
            Executar(f);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var f = @"
                    ALTER  FUNCTION [dbo].[STExtrato] (@ststamp char(30),@dData1 char(15),@dData2 char(15))
                    RETURNS TABLE 
                    AS
                    RETURN 
                    (
                    Select *,sum(entrada - saida)
			                    over(PARTITION BY ref order by tmp1.dataordem rows unbounded preceding) as saldo
			                    From(
				                    Select data = isnull(Convert(char(12),Data), 'Total'), descmovstk = isnull(descmovstk, ''), nrdoc, entrada = sum(entrada), saida = sum(saida),
			                    Armazemstamp = ISNULL(Armazemstamp, ''), numinterno = isnull(numinterno, ''), nome = ISNULL(nome, ''), datahora = isnull(datahora, ''), ordem = isnull(ordem, 4),
			                    dataordem = isnull(dataordem, ''), ref,Ststamp,descarm,Reserva,Encomenda,Vendido,Comprado 
			                    from(
				                    Select data = '', descmovstk = 'Saldo Alterior', nrdoc = 0, isnull(SUM(entrada), 0) entrada, isnull(SUM(saida), 0) saida, Armazemstamp = '',
			                    numinterno = '', nome = '', datahora = 0, ordem = 1, dataordem = 0, ref= '',Ststamp='',descarm=''
			                    ,Reserva=sum(Reserva-Reservasaida),Encomenda=sum(Encomenda-Encomendaentrada),Vendido=sum(Vendido-Vendidosaida),Comprado=sum(Comparado-Comparadoentrada) from mstk where CONVERT(date, data) < @dData1 and LTRIM(RTRIM(Ststamp)) = @ststamp 
				                    union all
			                    Select data = CONVERT(date, data), descmovstk, nrdoc, entrada, saida, Armazemstamp, numinterno, nome, datahora, ordem = 2, dataordem = datahora, ref,Ststamp,descarm=dbo.Decarm(Mstk.Armazemstamp)
			                    ,Reserva=sum(Reserva-Reservasaida),Encomenda=sum(Encomenda-Encomendaentrada),Vendido=sum(Vendido-Vendidosaida),Comprado=sum(Comparado-Comparadoentrada) from mstk
			                    where CONVERT(date, data) >= @dData1 and CONVERT(date, data)<=@dData2 and LTRIM(RTRIM(Ststamp)) = @ststamp group by data,descmovstk, nrdoc, entrada, saida,Armazemstamp, numinterno, nome,datahora,Ref,Ststamp
				                    )tmp0 group by grouping sets((Ststamp), (data, descmovstk, nrdoc, Armazemstamp, numinterno, nome, datahora, ordem, dataordem,ref,descarm,descarm,Reserva,Encomenda,Vendido,Comprado ))
				                    )tmp1
                    ) ";
            Executar(f);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var f = @"
                ALTER  FUNCTION [dbo].[STExtratoFicha](	@ststamp char(30))
                RETURNS TABLE 
                AS
                RETURN 
                (
	                select descarm=ISNULL(dbo.Decarm(Armazemstamp),'TOTAL ARMAZENS'), sum(entrada-saida) stock,Armazemstamp,Reserva=0,Encomenda=0,Vendido=0,Comprado=0  
	                from mstk where Ststamp=@ststamp group by ROLLUP (Armazemstamp)                                      
                ) ";
            Executar(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var f = @"
                    ALTER FUNCTION [dbo].[Decarm](@Armazemstamp char(30))

                    RETURNS varchar(200)
                    AS
                    BEGIN
	                    RETURN (select Descricao from Armazem where Armazemstamp=@Armazemstamp);
                    END
                    ";
            Executar(f);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var f = @"

                        ALTER  FUNCTION [dbo].[FNCCCF]()
                        RETURNS TABLE 
                        AS
                        RETURN 
                        (
		                        select descricao,nrdoc,data,valordoc,valorpreg,valorreg=valorpreg,ok,fccstamp,origem,oristamp,
		                        Moeda,Cambiousd,no,nome,Dias,ccusto,Fncstamp,vencim,Rcladiant,Entidadebanc='',Referencia=''  from (
		                        select (LTRIM(RTRIM(fcc.documento)) +'  '+Convert(varchar,fcc.nrdoc)) as descricao,nrdoc=iif((select Montanumero from param)=1,
		                        Convert(char(15),(select (CodInterno +'/'+Convert(char,numero)+'/'+Convert(char,YEAR(data))) nrdocc from facc where Faccstamp=fcc.fccstamp)),convert(char(12),fcc.nrdoc)),
		                        fcc.data,
		                        valordoc=iif(fcc.Rcladiant=1,iif(moeda = dbo.MoedaNacional(),-1*credito,-1*creditom),iif(moeda = dbo.MoedaNacional(),debito,debitom)),
		                        valorpreg=(iif(fcc.Rcladiant=1,iif(moeda = dbo.MoedaNacional(),-1*(credito-creditof),-1*(creditom-creditofm)),iif(moeda = dbo.MoedaNacional(),debito-debitof,debitom-debitofm))),
		                        valorreg=0,
		                        0 as ok,fcc.fccstamp,fcc.origem,oristamp,debito,credito,fcc.Cambiousd,fcc.no,fcc.nome,DATEDIFF(day,fcc.data,getdate()) as Dias,fcc.ccusto,moeda,fncstamp,vencim,fcc.Rcladiant
		                        from fcc where fcc.origem in ('FTF','PGFA','NCF','NDF') 
		                        group by documento,fcc.nrdoc,fcc.data,fcc.fccstamp,fcc.data,fcc.credito,fcc.debito,fcc.creditom,fcc.debitom,fcc.creditofm,fcc.creditof,fcc.debitofm,
		                        debitof,fcc.moeda,fcc.origem,oristamp,fcc.Cambiousd,fcc.no,fcc.nome,fcc.ccusto,Moeda,fncstamp,vencim,fcc.Rcladiant)tmp1
		                        where valorpreg<>0 
                        )          
                          
                    ";
            Executar(f);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var f = @"

                 ALTER TRIGGER [dbo].[tgFACTL_INSERT] 
                   ON  [dbo].[Factl] AFTER INSERT,UPDATE
                AS 
	                BEGIN
		                SET NOCOUNT ON
		                DECLARE
		                @Factstamp char(30),
		                @Factlstamp char(30),
		                @Ststamp char(30),
		                @ref char(20),
		                @Quant decimal(10,2),
		                @Cancelado bit,
		                @Servico bit,
		                @Descarm char(80),
		                @Codarm int;

		                Select @Factstamp=Factstamp,@Cancelado=LineAnulado,@Factlstamp=Factlstamp,@Ststamp=Ststamp,@Quant=quant,@Servico=servico,@Codarm=armazem,@Descarm=Descarm from inserted  
		                if @Servico=0
			                begin
				                IF EXISTS (Select Factstamp,movstk FROM fact where factstamp=@Factstamp and movstk=1)
					                BEGIN
					                if @Cancelado=0
						                begin
						                if not exists(select Mstkstamp from Mstk where Mstkstamp =@Factlstamp)
							                begin 
								                INSERT INTO [dbo].[mstk]
								                ([mstkstamp],[origem],[oristamp],[stampcab],[Faccstamp],[Facclstamp],[factlstamp],[dilstamp],[ivlstamp],[Factstamp],[Distamp],[Ivstamp],
								                [nrdoc],[no],[nome],[data],[tipodoc],[numdoc],[entidade],[documento],[Moeda],[numinterno],[codmovstk],[descmovstk],
								                [ref],[descricao],[entrada],[saida],[codarm],[preco],[preco2],[preco3],[ivainc],[tabiva],[txiva],
								                [Turno],[Vendedor],[codvend],[serie],[usalote],[lote],Totalmedida,Datahora,[lotevalid],[lotelimft],[qttmedida],[Vendido],[Reservasaida],Entidadestamp,Ststamp,Armazemstamp,Ccusto,Ccustamp,Usrstamp)	
					
								                Select factl.factlstamp,origem=fact.sigla,factl.Factlstamp,factl.factstamp,faccstamp=null,Facclstamp=null,
								                factl.factlstamp,dilstamp=null,ivlstamp=null,Factl.Factstamp,Distamp=null,Ivstamp=null,
								                Fact.numero,Fact.no,Fact.nome,Fact.data,Fact.sigla,Fact.numdoc,entidade=1,Fact.nomedoc,Fact.moeda,Fact.numinterno,Fact.codmovstk,Fact.descmovstk,
								                Factl.ref,Factl.descricao,entrada=(case when Fact.codmovstk < 50 then 
												
												
												iif(Factl.Usaquant2=1,Factl.quant2, IIF(fact.Nc=1,(-1)*factl.quant,factl.quant))
												
												else 0 end),saida=(case when Fact.codmovstk > 50 then iif(fact.reserva=1,0,iif(Factl.Usaquant2=1,Factl.quant2, Factl.quant)) else 0 end),Factl.armazem,Factl.preco,
								                preco2=((Factl.totall-Factl.valival)/(case when Factl.quant=0 then 1 else Factl.quant end)),
								                preco3=(Factl.totall/(case when Factl.quant=0 then 1 else Factl.quant end)),Factl.ivainc,
								                Factl.tabiva,Factl.txiva,Turno='',Vendedor='',codvend=0,serie='',Factl.usalote,Factl.lote,0,getdate(),getdate(),getdate(),0,Vendido=(case when Fact.Vendido =1 then Factl.quant else 0 end)
								                ,Reservasaida=(case when Fact.Reserva =1 then Factl.quant else 0 end),factl.Entidadestamp,factl.Ststamp,Factl.Armazemstamp,fact.Ccusto,Fact.Ccustamp,fact.Usrstamp
								                from Fact inner join (Factl left join mstk on Factl.Factlstamp=mstk.Factlstamp) on Fact.Factstamp=Factl.Factstamp
								                where Factl.Factstamp=@Factstamp and Fact.movstk=1 and Factl.servico=0 and Factl.nmovstk=0 and mstk.mstkstamp is null 
							                end
						                ELSE 
							                BEGIN 		
									                UPDATE mstk SET entrada=(case when Fact.codmovstk < 50 then 	iif(Factl.Usaquant2=1,Factl.quant2, IIF(fact.Nc=1,(-1)*factl.quant,factl.quant)) else 0 end),
									                saida=(case when Fact.codmovstk > 50 then 	iif(Factl.Usaquant2=1,Factl.quant2, IIF(fact.Nc=1,(-1)*factl.quant,factl.quant)) else 0 end),no=Fact.no,nome=Fact.nome,
									                descricao=Factl.descricao,preco=Factl.preco,ivainc=Factl.ivainc,tabiva=Factl.tabiva,
									                preco2=((Factl.totall-Factl.valival)/(case when Factl.quant=0 then 1 else Factl.quant end)),
									                preco3=(Factl.totall/(case when Factl.quant=0 then 1 else Factl.quant end)),
									                txiva=Factl.txiva,usalote=Factl.usalote,lote=Factl.lote,
									                codarm=Factl.armazem,
									                data=Fact.data,Vendido=(case when Fact.Vendido =1 then Factl.quant else 0 end) 
									                ,Reservasaida=(case when Fact.reserva =1 then Factl.quant else 0 end),Ststamp = Factl.Ststamp,Armazemstamp=factl.Armazemstamp, 
									                Ccusto =fact.Ccusto,Ccustamp =Fact.Ccustamp,Usrstamp = Fact.Usrstamp

									                from Fact inner join (Factl left join mstk on Factl.Factlstamp=mstk.Factlstamp) on Fact.Factstamp=Factl.Factstamp
									                where Factl.Factstamp=@Factstamp and Fact.movstk=1 and Factl.servico=0 and Factl.nmovstk=0
							                END	
						                end 
					                else
						                begin 
							                delete from Mstk where Mstkstamp = @Factlstamp and Factstamp=@Factstamp
						                end 
					                --Exec [dbo].[MSTK_STARM] @ref,@codarm,@Quant,@Ststamp,@Descarm
				                END
			                end 
	                END         
                  
                    ";
            Executar(f);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var f = @"DECLARE @numero as NVARCHAR(5)
                DECLARE @Factstamp as NVARCHAR(150)

                DECLARE Employee_Cursor CURSOR FOR  
                select numero,Factstamp from ITTEST..fact where ITTEST..fact.nome='HIGEST MOCAMBIQUE LDA'
                OPEN Employee_Cursor;  
                FETCH NEXT FROM Employee_Cursor INTO @numero, @Factstamp;  
                WHILE @@FETCH_STATUS = 0  
                   BEGIN  
                      update fact set numero =@numero where Factstamp =@Factstamp
                      FETCH NEXT FROM Employee_Cursor INTO @numero, @Factstamp;   
                   END;  
                CLOSE Employee_Cursor;  
                DEALLOCATE Employee_Cursor;  
                GO ";
            tbScript.Text = f;
            MsBox.Show(f);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var f = @"
                    DECLARE @numero as NVARCHAR(5)
                    DECLARE @Factstamp as NVARCHAR(150)

                    DECLARE Employee_Cursor CURSOR FOR  
                    select no,Factstamp from fact where Clstamp=''
                    OPEN Employee_Cursor;  
                    FETCH NEXT FROM Employee_Cursor INTO @numero, @Factstamp;  
                    WHILE @@FETCH_STATUS = 0  
                       BEGIN  
                          update fact set Clstamp =(select Clstamp from cl where no=@numero) where Factstamp =@Factstamp
                          FETCH NEXT FROM Employee_Cursor INTO @numero, @Factstamp;   
                       END;  
                    CLOSE Employee_Cursor;  
                    DEALLOCATE Employee_Cursor;  
                    GO         
                    ";
            Executar(f);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var f = @"
                        DECLARE @numero as NVARCHAR(5)
                        DECLARE @Factstamp as NVARCHAR(150)

                        DECLARE Employee_Cursor CURSOR FOR  
                        select no,Faccstamp from facc --where fncstamp=''
                        OPEN Employee_Cursor;  
                        FETCH NEXT FROM Employee_Cursor INTO @numero, @Factstamp;  
                        WHILE @@FETCH_STATUS = 0  
                           BEGIN  
                              update facc set fncstamp =(select fncstamp from fnc where no=@numero) where Faccstamp =@Factstamp
                              FETCH NEXT FROM Employee_Cursor INTO @numero, @Factstamp;   
                           END;  
                        CLOSE Employee_Cursor;  
                        DEALLOCATE Employee_Cursor;  
                        GO          
                    ";
            tbScript.Text = f;
            SQL.SqlCmd(f);
            MsBox.Show("Processo executado com sucesso");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var f = @"
            ALTER TRIGGER [dbo].[tgFTCC] 
   ON  [dbo].[Fact] AFTER INSERT,UPDATE
AS 
BEGIN
	DECLARE
	@clstamp char(30),
	@moeda char(10),
	@Factstamp char(30),@movcc bit,@movtz bit,@codmovcc decimal(16,2),@Anulado bit
	Select @Factstamp=Factstamp,@movcc=movcc,@movtz=movtz,@codmovcc=codmovcc,@clstamp=Clstamp,@moeda=Moeda,@Anulado=Anulado from inserted
	if @Anulado=0
	begin 
	IF NOT EXISTS (Select Factstamp FROM cc where factstamp=@Factstamp) and @movcc=1
	Begin
		INSERT INTO [dbo].[cc]
			([ccstamp],[origem],[oristamp],[nrdoc],[no],[nome],[data],[vencim],[debito],[debitom],[debitof],[debitofm],[credito]
			,[creditom],[creditof],[creditofm],[documento],[Moeda],[saldo],[codmov],[Factstamp],
			[rclstamp],[rdstamp],[ccusto],[numinterno],estabno,estabnome,Cambiousd,Clstamp,Usrstamp,Pos)
		Select factstamp,origem=Sigla,factstamp,numero,no,nome,data,dataven,total,mtotal,debitof=0,debitofm=0,credito=0,creditom=0,
		creditof=0,creditofm=0,descmovcc,Moeda,saldo=0,codmovcc,Factstamp,rclstamp=null,rdstamp=null,
		ccusto,numinterno,0,'',Cambiousd,Clstamp,Usrstamp,Pos
		from inserted where movcc=1 and movtz=0
	End

	IF EXISTS (Select Factstamp FROM cc where factstamp=@Factstamp) and @movcc=1
	Begin
		update cc set no=inserted.no,nome=inserted.nome,data=inserted.data,vencim=inserted.dataven,debito=inserted.total,
		debitom=inserted.mtotal,numinterno=inserted.numinterno,Cambiousd=inserted.Cambiousd,Clstamp=inserted.Clstamp
		from inserted inner join cc on cc.factstamp=inserted.factstamp where movcc=1 and movtz=0

	End
	end 
	else 
	begin 
			delete from cc where Factstamp=@Factstamp
	end 
END";
            Executar(f);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var f = @"
	         alter table param  add   [Anolectivo] [decimal](9, 0) NOT NULL default(0)	
	         alter table param add [AnoSem] [nvarchar](80) NOT NULL default('')        
                    ";
            tbScript.Text = f;
            SQL.SqlCmd(f);
            MsBox.Show("Processo executado com sucesso");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var f = @"
                    ALTER TRIGGER [dbo].[tgRCLLCC] 
                       ON  [dbo].[RCLL]
                       AFTER INSERT,UPDATE
                    AS 
                    BEGIN
	                    DECLARE
	                    @Cancelado bit,
	                    @Rcladiant bit,
	                    @pago numeric
	                    Select @Cancelado=inserted.anulado,@Rcladiant=inserted.Rcladiant,@pago=inserted.valorreg from inserted join rcl on inserted.Rclstamp=rcl.Rclstamp
	                    if @Rcladiant=0
		                    begin 
		                    if @pago>0
			                    begin 
				                    update cc set debitof=debitof+inserted.valorreg,debitofm=debitofm+inserted.mvalorreg from inserted where inserted.Ccstamp=cc.ccstamp
			                    end 
			                    else
			                    begin
			                        --update cc set debitof=debitof+inserted.valorreg,debitofm=debitofm+inserted.mvalorreg from inserted where inserted.Ccstamp=cc.ccstamp
				                    update cc set debitof=debitof+(-1*inserted.valorreg),debitofm=debitofm+(-1*inserted.mvalorreg) from inserted where inserted.Ccstamp=cc.ccstamp
			                    end 
		                    end
	                    else 
		                    begin
		                    update cc set creditof=creditof+(-1*inserted.valorreg),creditofm=creditofm+(-1*inserted.mvalorreg) from inserted where inserted.Ccstamp=cc.ccstamp
		                    end 
	                    if @Cancelado=1
		                    begin 
			                    if @Rcladiant=0
			                    begin
				                    update cc set debitof =0,debitofm=0 from inserted where inserted.Ccstamp=cc.ccstamp

									
			                    end 
			                    else 
			                    begin 
				                    update cc set creditof = creditof-(-1*inserted.valorreg) from inserted where inserted.Ccstamp=cc.ccstamp
			                    end 
		                    end
                    END
                    
                    ";
            Executar(f);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var f = @"
                       ALTER TRIGGER [dbo].[tgFTCC] 
   ON  [dbo].[Fact] AFTER INSERT,UPDATE
AS 
BEGIN
	DECLARE
	@clstamp char(30),
	@moeda char(10),
	@Factstamp char(30),@movcc bit,@movtz bit,@codmovcc decimal(16,2),@Anulado bit
	Select @Factstamp=Factstamp,@movcc=movcc,@movtz=movtz,@codmovcc=codmovcc,@clstamp=Clstamp,@moeda=Moeda,@Anulado=Anulado from inserted
	if @Anulado=0
	begin 
	IF NOT EXISTS (Select Factstamp FROM cc where factstamp=@Factstamp) and @movcc=1
	Begin
		INSERT INTO [dbo].[cc]
			([ccstamp],[origem],[oristamp],[nrdoc],[no],[nome],[data],[vencim],[debito],[debitom],[debitof],[debitofm],[credito]
			,[creditom],[creditof],[creditofm],[documento],[Moeda],[saldo],[codmov],[Factstamp],
			[rclstamp],[rdstamp],[ccusto],[numinterno],estabno,estabnome,Cambiousd,Clstamp,Usrstamp,Pos,Referencia,Entidadebanc)
		Select factstamp,origem=Sigla,factstamp,numero,no,nome,data,dataven,total,mtotal,debitof=0,debitofm=0,credito=0,creditom=0,
		creditof=0,creditofm=0,descmovcc,Moeda,saldo=0,codmovcc,Factstamp,rclstamp=null,rdstamp=null,
		ccusto,numinterno,0,'',Cambiousd,Clstamp,Usrstamp,Pos,Referencia,Entidadebanc
		from inserted where movcc=1 and movtz=0
	End

	IF EXISTS (Select Factstamp FROM cc where factstamp=@Factstamp) and @movcc=1
	Begin
		update cc set no=inserted.no,nome=inserted.nome,data=inserted.data,vencim=inserted.dataven,debito=inserted.total,
		debitom=inserted.mtotal,numinterno=inserted.numinterno,Cambiousd=inserted.Cambiousd,Clstamp=inserted.Clstamp,Referencia=inserted.Referencia,Entidadebanc=inserted.Entidadebanc
		from inserted inner join cc on cc.factstamp=inserted.factstamp where movcc=1 and movtz=0

	End
	end 
	else 
	begin 
			delete from cc where Factstamp=@Factstamp
	end 
END
                    
                    ";
            Executar(f);
        }

        private void gridUi1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
