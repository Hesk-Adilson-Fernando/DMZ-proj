namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class colunprecoposs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Preconormal", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Preconormal");
        }
    }
}
