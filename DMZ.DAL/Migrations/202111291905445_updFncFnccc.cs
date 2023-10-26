namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFncFnccc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fnc", "Generico", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fnc", "Fncivainc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fnc", "Ctrlplanfond", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fnc", "Ctrlplanfond");
            DropColumn("dbo.Fnc", "Fncivainc");
            DropColumn("dbo.Fnc", "Generico");
        }
    }
}
