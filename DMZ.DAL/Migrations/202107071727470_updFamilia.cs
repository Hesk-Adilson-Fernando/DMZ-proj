namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFamilia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Familia", "Cpoc", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Familia", "Cpoc");
        }
    }
}
