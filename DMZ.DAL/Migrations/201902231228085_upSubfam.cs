namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upSubfam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SubFam", "Descpos", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubFam", "Descpos", c => c.Boolean(nullable: false));
        }
    }
}
