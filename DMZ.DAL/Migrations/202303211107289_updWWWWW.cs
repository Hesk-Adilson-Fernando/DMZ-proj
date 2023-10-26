namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updWWWWW : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turma", "Descanoaem", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turma", "Descanoaem");
        }
    }
}
