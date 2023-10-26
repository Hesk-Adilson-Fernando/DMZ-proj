namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRH5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prcdesc", "Prcstamp", "dbo.Prc");
            DropForeignKey("dbo.Prcemp", "Prcstamp", "dbo.Prc");
            DropForeignKey("dbo.Prcextra", "Prc_Prcstamp", "dbo.Prc");
            DropForeignKey("dbo.Prcsub", "Prcstamp", "dbo.Prc");
            DropIndex("dbo.Prcdesc", new[] { "Prcstamp" });
            DropIndex("dbo.Prcemp", new[] { "Prcstamp" });
            DropIndex("dbo.Prcextra", new[] { "Prc_Prcstamp" });
            DropIndex("dbo.Prcsub", new[] { "Prcstamp" });
            AddColumn("dbo.Prc", "Referenc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Valor", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "Taxa", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.Prc", "Fixo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Prc", "Quant", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "Tipo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Codsind", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "BaseVencimento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "TotalVencimento", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "TotalAbonus", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "TotalDescontos", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "TotalLiquido", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "Tempo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Departamento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "ValorIrpsAlim", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "Diassal", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Periodo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "ValorSeguroEmp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "ValorSeguroFunc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "ValorSegSocemp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "ValorSegSocFunc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "SegSocial", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "SalarioHora", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "CCusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "ContaEmpresa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "TabIrps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "TaxaIrps", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.Prc", "SalHoraHExtra", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "SalHoraTurno", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "FundoPensao", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "DiasPrc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Cambio", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.Prc", "CambioMoeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "CambioValor", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pe", "DataAdmissao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "DataFimContrato", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "DataDemissao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pefer", "DiasDireito", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasAdicionais", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasAnoAnterior", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "TotalDias", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasPorGozar", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasJaGozados", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasPorMarcar", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasFeriasJaPagas", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "PeriodosFerias", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "FuncSemFerias", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefer", "DiasAdicionaisAntig", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasAdicionaisAssid", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasAdicionaisIdade", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefer", "DiasAntecipados", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Prc", "Mes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Prc", "No", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Prc", "Codsit", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Prc", "ValEmp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Prc", "SegSocEmp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Prc", "Nrmes");
            DropColumn("dbo.Prc", "Codcat");
            DropColumn("dbo.Prc", "Cat");
            DropColumn("dbo.Prc", "Coddesc");
            DropColumn("dbo.Prc", "Codfun");
            DropColumn("dbo.Prc", "Codesc");
            DropColumn("dbo.Prc", "Escalao");
            DropColumn("dbo.Prc", "Indice");
            DropColumn("dbo.Prc", "codsec");
            DropColumn("dbo.Prc", "codcl");
            DropColumn("dbo.Prc", "classe");
            DropColumn("dbo.Prc", "quota");
            DropColumn("dbo.Prc", "sind");
            DropColumn("dbo.Prc", "nsind");
            DropColumn("dbo.Prc", "situacao");
            DropColumn("dbo.Prc", "BaseCateg");
            DropColumn("dbo.Prc", "totsub");
            DropColumn("dbo.Prc", "totabonus");
            DropColumn("dbo.Prc", "totdesc");
            DropColumn("dbo.Prc", "liquido");
            DropColumn("dbo.Prc", "fechado");
            DropColumn("dbo.Prc", "valoremp");
            DropColumn("dbo.Prcextra", "Prc_Prcstamp");
            DropTable("dbo.Prcdesc");
            DropTable("dbo.Prcsub");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Prcsub",
                c => new
                    {
                        Prcsubstamp = c.String(nullable: false, maxLength: 30),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Taxa = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Prcstamp = c.String(nullable: false, maxLength: 80),
                        Tiposub = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fixo = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Prcsubstamp);
            
            CreateTable(
                "dbo.Prcdesc",
                c => new
                    {
                        Prcdescstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Taxa = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Prcstamp = c.String(nullable: false, maxLength: 80),
                        Tipodesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fixo = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Taxa2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Prcdescstamp);
            
            AddColumn("dbo.Prcextra", "Prc_Prcstamp", c => c.String(maxLength: 80));
            AddColumn("dbo.Prc", "valoremp", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "fechado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Prc", "liquido", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "totdesc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "totabonus", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "totsub", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "BaseCateg", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "situacao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "nsind", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "sind", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "quota", c => c.Boolean(nullable: false));
            AddColumn("dbo.Prc", "classe", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "codcl", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "codsec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Indice", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Escalao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Codesc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Codfun", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Coddesc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Cat", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Codcat", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Nrmes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Prc", "SegSocEmp", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Prc", "ValEmp", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Prc", "Codsit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Prc", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Prc", "Mes", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Pefer", "DiasAntecipados");
            DropColumn("dbo.Pefer", "DiasAdicionaisIdade");
            DropColumn("dbo.Pefer", "DiasAdicionaisAssid");
            DropColumn("dbo.Pefer", "DiasAdicionaisAntig");
            DropColumn("dbo.Pefer", "FuncSemFerias");
            DropColumn("dbo.Pefer", "PeriodosFerias");
            DropColumn("dbo.Pefer", "DiasFeriasJaPagas");
            DropColumn("dbo.Pefer", "DiasPorMarcar");
            DropColumn("dbo.Pefer", "DiasJaGozados");
            DropColumn("dbo.Pefer", "DiasPorGozar");
            DropColumn("dbo.Pefer", "TotalDias");
            DropColumn("dbo.Pefer", "DiasAnoAnterior");
            DropColumn("dbo.Pefer", "DiasAdicionais");
            DropColumn("dbo.Pefer", "DiasDireito");
            DropColumn("dbo.Pe", "DataDemissao");
            DropColumn("dbo.Pe", "DataFimContrato");
            DropColumn("dbo.Pe", "DataAdmissao");
            DropColumn("dbo.Prc", "CambioValor");
            DropColumn("dbo.Prc", "CambioMoeda");
            DropColumn("dbo.Prc", "Cambio");
            DropColumn("dbo.Prc", "Moeda");
            DropColumn("dbo.Prc", "DiasPrc");
            DropColumn("dbo.Prc", "FundoPensao");
            DropColumn("dbo.Prc", "SalHoraTurno");
            DropColumn("dbo.Prc", "SalHoraHExtra");
            DropColumn("dbo.Prc", "TaxaIrps");
            DropColumn("dbo.Prc", "TabIrps");
            DropColumn("dbo.Prc", "ContaEmpresa");
            DropColumn("dbo.Prc", "CCusto");
            DropColumn("dbo.Prc", "SalarioHora");
            DropColumn("dbo.Prc", "SegSocial");
            DropColumn("dbo.Prc", "ValorSegSocFunc");
            DropColumn("dbo.Prc", "ValorSegSocemp");
            DropColumn("dbo.Prc", "ValorSeguroFunc");
            DropColumn("dbo.Prc", "ValorSeguroEmp");
            DropColumn("dbo.Prc", "Periodo");
            DropColumn("dbo.Prc", "Diassal");
            DropColumn("dbo.Prc", "ValorIrpsAlim");
            DropColumn("dbo.Prc", "Departamento");
            DropColumn("dbo.Prc", "Tempo");
            DropColumn("dbo.Prc", "TotalLiquido");
            DropColumn("dbo.Prc", "TotalDescontos");
            DropColumn("dbo.Prc", "TotalAbonus");
            DropColumn("dbo.Prc", "TotalVencimento");
            DropColumn("dbo.Prc", "BaseVencimento");
            DropColumn("dbo.Prc", "Codsind");
            DropColumn("dbo.Prc", "Tipo");
            DropColumn("dbo.Prc", "Quant");
            DropColumn("dbo.Prc", "Fixo");
            DropColumn("dbo.Prc", "Taxa");
            DropColumn("dbo.Prc", "Valor");
            DropColumn("dbo.Prc", "Descricao");
            DropColumn("dbo.Prc", "Referenc");
            CreateIndex("dbo.Prcsub", "Prcstamp");
            CreateIndex("dbo.Prcextra", "Prc_Prcstamp");
            CreateIndex("dbo.Prcemp", "Prcstamp");
            CreateIndex("dbo.Prcdesc", "Prcstamp");
            AddForeignKey("dbo.Prcsub", "Prcstamp", "dbo.Prc", "Prcstamp", cascadeDelete: true);
            AddForeignKey("dbo.Prcextra", "Prc_Prcstamp", "dbo.Prc", "Prcstamp");
            AddForeignKey("dbo.Prcemp", "Prcstamp", "dbo.Prc", "Prcstamp", cascadeDelete: true);
            AddForeignKey("dbo.Prcdesc", "Prcstamp", "dbo.Prc", "Prcstamp", cascadeDelete: true);
        }
    }
}
