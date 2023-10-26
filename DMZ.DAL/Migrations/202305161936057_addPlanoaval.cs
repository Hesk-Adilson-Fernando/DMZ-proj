namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPlanoaval : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tiporesult",
                c => new
                    {
                        Tiporesultstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Tiporesultstamp);
            
            AddColumn("dbo.Fact", "Multa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Multa", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Multa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Cancelamulta", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Cancelamulta");
            DropColumn("dbo.St", "Multa");
            DropColumn("dbo.Tdoc", "Multa");
            DropColumn("dbo.Fact", "Multa");
            DropTable("dbo.Tiporesult");
        }
    }
}
