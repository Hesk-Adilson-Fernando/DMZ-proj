namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUpdCAixa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caixa", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixa", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixa", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Formasp", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Formasp", "Nome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Formasp", "Numero", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Formasp", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Formasp", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formasp", "Ccustamp");
            DropColumn("dbo.Formasp", "Ccusto");
            DropColumn("dbo.Formasp", "Numero");
            DropColumn("dbo.Formasp", "Nome");
            DropColumn("dbo.Formasp", "No");
            DropColumn("dbo.Caixa", "Moeda");
            DropColumn("dbo.Caixa", "Ccustamp");
            DropColumn("dbo.Caixa", "Ccusto");
        }
    }
}
