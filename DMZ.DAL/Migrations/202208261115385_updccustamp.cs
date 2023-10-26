namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updccustamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mstk", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Facc", "Ccustamp");
            DropColumn("dbo.Di", "Ccustamp");
            DropColumn("dbo.Mstk", "Ccustamp");
            DropColumn("dbo.Fact", "Ccustamp");
        }
    }
}
