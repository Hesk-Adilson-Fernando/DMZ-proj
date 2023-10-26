namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPlanoF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlanoFeria", "CCusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.PlanoFeria", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.PlanoFeria", "Planogeral", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlanoFeria", "Planogeral");
            DropColumn("dbo.PlanoFeria", "Ccustamp");
            DropColumn("dbo.PlanoFeria", "CCusto");
        }
    }
}
