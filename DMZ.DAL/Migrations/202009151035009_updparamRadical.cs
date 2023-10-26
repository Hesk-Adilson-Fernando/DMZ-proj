namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updparamRadical : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Usaradicalfact", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Radicalfact", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Radicalfact");
            DropColumn("dbo.Param", "Usaradicalfact");
        }
    }
}
