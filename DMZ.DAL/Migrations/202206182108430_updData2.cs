namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updData2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rltsql", "Querry", c => c.String(nullable: false, maxLength: 3000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rltsql", "Querry", c => c.String(nullable: false, maxLength: 2000));
        }
    }
}
