namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updparam130921 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Totalinteiro", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Totalinteiro");
        }
    }
}
