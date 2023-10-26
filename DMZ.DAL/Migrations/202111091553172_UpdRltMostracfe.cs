namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRltMostracfe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "Mostracfe", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rlt", "Mostracfe");
        }
    }
}
