namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addplanog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grade", "Planopagstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Grade", "Descplano", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grade", "Descplano");
            DropColumn("dbo.Grade", "Planopagstamp");
        }
    }
}
