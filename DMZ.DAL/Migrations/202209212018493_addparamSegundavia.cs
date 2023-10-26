namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addparamSegundavia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Segundavia", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Segundavia");
        }
    }
}
