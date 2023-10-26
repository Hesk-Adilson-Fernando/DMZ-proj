namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addnumdocs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Numdocs",
                c => new
                    {
                        Numdocsstamp = c.String(nullable: false, maxLength: 80),
                        Oristamp = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        CCusto = c.String(nullable: false, maxLength: 80),
                        Codccu = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Numdocsstamp);
            
            AddColumn("dbo.Pehextra", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pehextra", "Tipo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pehextra", "Tempo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pehextra", "Tempo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pehextra", "Tipo");
            DropColumn("dbo.Pehextra", "Valor");
            DropTable("dbo.Numdocs");
        }
    }
}
