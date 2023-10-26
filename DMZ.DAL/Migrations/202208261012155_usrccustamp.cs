namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usrccustamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Ccustamp");
        }
    }
}
