namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFam2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Familia", "Descpos", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Familia", "Descpos", c => c.Boolean(nullable: false));
        }
    }
}
