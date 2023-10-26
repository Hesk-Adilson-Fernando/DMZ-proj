namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fnc2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fnc",
                c => new
                    {
                        Fncstamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(maxLength: 80),
                        Morada = c.String(maxLength: 80),
                        Telefone = c.String(maxLength: 80),
                        Celular = c.String(maxLength: 80),
                        Fax = c.String(maxLength: 80),
                        Email = c.String(maxLength: 80),
                        Nuit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipo = c.String(maxLength: 80),
                        Saldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Obs = c.String(maxLength: 80),
                        Pais = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        Codarm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Armazem = c.String(maxLength: 80),
                        imagem = c.Binary(),
                        Prontopag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Fncstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fnc");
        }
    }
}
