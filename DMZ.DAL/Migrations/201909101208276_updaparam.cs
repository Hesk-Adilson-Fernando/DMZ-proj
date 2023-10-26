namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updaparam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.A_param", "motivoiva", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.A_param", "motivoivaeng", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.A_param", "outGoingEmailp", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.A_param", "subjp", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.A_param", "subjp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.A_param", "outGoingEmailp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.A_param", "motivoivaeng", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.A_param", "motivoiva", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
