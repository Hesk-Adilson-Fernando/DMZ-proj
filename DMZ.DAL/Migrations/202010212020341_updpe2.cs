namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updpe2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pesit", "Pestamp", "dbo.Pe");
            DropIndex("dbo.Pesit", new[] { "Pestamp" });
            AddColumn("dbo.Pe", "Dcasa", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "Pais", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodNivel", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Nivel", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Categ", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codprof", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Prof", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codep", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Depart", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codrep", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Repart", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Irps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Percirps", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pe", "Inss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Nrinss", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Percinss", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pe", "Obs", c => c.String(nullable: false, maxLength: 500));
            AddColumn("dbo.Pecont", "Contacto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefam", "Tel", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefam", "Email", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pehextra", "Data", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pesub", "Perc", c => c.Decimal(nullable: false, precision: 9, scale: 2));
            AlterColumn("dbo.Pe", "ValBasico", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Pe", "RegimeCasamento");
            DropColumn("dbo.Pe", "DataCasamento");
            DropColumn("dbo.Pe", "CodNivelAcademico");
            DropColumn("dbo.Pe", "NivelAcademico");
            DropColumn("dbo.Pe", "DescricaoCateg");
            DropColumn("dbo.Pe", "CodProfissao");
            DropColumn("dbo.Pe", "DescProfissao");
            DropColumn("dbo.Pe", "CodDepart");
            DropColumn("dbo.Pe", "DescDepart");
            DropColumn("dbo.Pe", "CodRepart");
            DropColumn("dbo.Pe", "DescRepart");
            DropColumn("dbo.Pe", "CodSeccao");
            DropColumn("dbo.Pe", "DescSeccao");
            DropColumn("dbo.Pe", "DescIrps");
            DropColumn("dbo.Pe", "PercentagemIrps");
            DropColumn("dbo.Pe", "InscritoInss");
            DropColumn("dbo.Pe", "NrSegurancaSocial");
            DropColumn("dbo.Pe", "NomeRelPonto");
            DropColumn("dbo.Pe", "UtilValBasico");
            DropColumn("dbo.Pe", "ObservacaoPe");
            DropColumn("dbo.Pe", "Valbase");
            DropColumn("dbo.Pecont", "NrTelefEmail");
            DropColumn("dbo.Pecontra", "Status");
            DropColumn("dbo.Pefam", "DataNasc");
            DropColumn("dbo.Pefam", "Prov");
            DropColumn("dbo.Pefam", "Dist");
            DropColumn("dbo.Pefam", "Pad");
            DropColumn("dbo.Pefer", "Status");
            DropTable("dbo.Pesit");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pesit",
                c => new
                    {
                        Pesitstamp = c.String(nullable: false, maxLength: 80),
                        TipoInfracao = c.String(nullable: false, maxLength: 80),
                        NrProcesso = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.String(nullable: false, maxLength: 80),
                        Pena = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pesitstamp);
            
            AddColumn("dbo.Pefer", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefam", "Pad", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefam", "Dist", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefam", "Prov", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefam", "DataNasc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pecontra", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pecont", "NrTelefEmail", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Valbase", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "ObservacaoPe", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "UtilValBasico", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "NomeRelPonto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "NrSegurancaSocial", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "InscritoInss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "PercentagemIrps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "DescIrps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "DescSeccao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodSeccao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescRepart", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodRepart", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescDepart", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodDepart", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescProfissao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodProfissao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescricaoCateg", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "NivelAcademico", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodNivelAcademico", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DataCasamento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "RegimeCasamento", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Pe", "ValBasico", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pesub", "Perc");
            DropColumn("dbo.Pehextra", "Data");
            DropColumn("dbo.Pefam", "Email");
            DropColumn("dbo.Pefam", "Tel");
            DropColumn("dbo.Pecont", "Contacto");
            DropColumn("dbo.Pe", "Obs");
            DropColumn("dbo.Pe", "Percinss");
            DropColumn("dbo.Pe", "Nrinss");
            DropColumn("dbo.Pe", "Inss");
            DropColumn("dbo.Pe", "Percirps");
            DropColumn("dbo.Pe", "Irps");
            DropColumn("dbo.Pe", "Repart");
            DropColumn("dbo.Pe", "Codrep");
            DropColumn("dbo.Pe", "Depart");
            DropColumn("dbo.Pe", "Codep");
            DropColumn("dbo.Pe", "Prof");
            DropColumn("dbo.Pe", "Codprof");
            DropColumn("dbo.Pe", "Categ");
            DropColumn("dbo.Pe", "Nivel");
            DropColumn("dbo.Pe", "CodNivel");
            DropColumn("dbo.Pe", "Pais");
            DropColumn("dbo.Pe", "Dcasa");
            CreateIndex("dbo.Pesit", "Pestamp");
            AddForeignKey("dbo.Pesit", "Pestamp", "dbo.Pe", "Pestamp", cascadeDelete: true);
        }
    }
}
