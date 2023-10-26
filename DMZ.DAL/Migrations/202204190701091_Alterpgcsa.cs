namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alterpgcsa : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Pgcsa");
            AddColumn("dbo.Pgcsa", "Pgcstamp", c => c.String(nullable: false, maxLength: 80));
            AddPrimaryKey("dbo.Pgcsa", "Pgcsastamp");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Pgcsa");
            DropColumn("dbo.Pgcsa", "Pgcstamp");
            AddPrimaryKey("dbo.Pgcsa", new[] { "Conta", "Ano", "Mes" });
        }
    }
}
