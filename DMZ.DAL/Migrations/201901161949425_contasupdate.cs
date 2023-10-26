namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contasupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "Data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contas", "Data");
        }
    }
}
