namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfamiliaonfnc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fnc", "Familia", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fnc", "Familia");
        }
    }
}
