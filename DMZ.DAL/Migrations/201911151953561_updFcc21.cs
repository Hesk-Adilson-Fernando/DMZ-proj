namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFcc21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fcc", "Reffornec", c => c.String(maxLength: 80));
            AlterColumn("dbo.Fcc", "Numinterno", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fcc", "Numinterno", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fcc", "Reffornec", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
