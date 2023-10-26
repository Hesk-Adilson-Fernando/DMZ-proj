namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updSSSSSSSSSSS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prc", "Mesesstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CCu", "Director", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CCu", "Director");
            DropColumn("dbo.Prc", "Mesesstamp");
        }
    }
}
