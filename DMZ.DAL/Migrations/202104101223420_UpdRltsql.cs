namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRltsql : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rltsql", "Querry", c => c.String(nullable: false, maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rltsql", "Querry", c => c.String(nullable: false, maxLength: 1200));
        }
    }
}
