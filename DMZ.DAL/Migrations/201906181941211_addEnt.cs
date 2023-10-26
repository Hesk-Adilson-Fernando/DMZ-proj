namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEnt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ent",
                c => new
                    {
                        Entstamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Morada = c.String(nullable: false, maxLength: 80),
                        Telefone = c.String(nullable: false, maxLength: 80),
                        Celular = c.String(nullable: false, maxLength: 80),
                        Fax = c.String(nullable: false, maxLength: 80),
                        Cp = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Email = c.String(nullable: false, maxLength: 80),
                        Nuit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Zona = c.String(nullable: false, maxLength: 80),
                        Tipo = c.String(nullable: false, maxLength: 80),
                        CodVend = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vendedor = c.String(nullable: false, maxLength: 80),
                        Nimpexp = c.String(nullable: false, maxLength: 80),
                        Perdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Status = c.Boolean(nullable: false),
                        Campo1 = c.String(nullable: false, maxLength: 80),
                        Campo2 = c.String(nullable: false, maxLength: 80),
                        Campo3 = c.String(nullable: false, maxLength: 80),
                        Campo4 = c.String(nullable: false, maxLength: 80),
                        Tabela = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Datacl = c.DateTime(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Pais = c.String(nullable: false, maxLength: 80),
                        Qmc = c.String(nullable: false, maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        Qma = c.String(nullable: false, maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                        Localidade = c.String(nullable: false, maxLength: 80),
                        Codpais = c.String(nullable: false, maxLength: 80),
                        Codarm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descarm = c.String(nullable: false, maxLength: 80),
                        Clivainc = c.Boolean(nullable: false),
                        Codcondpag = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descondpag = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Entstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ent");
        }
    }
}
