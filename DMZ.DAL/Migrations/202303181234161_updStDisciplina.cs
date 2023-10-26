namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updStDisciplina : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Disciplina", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Disciplina");
        }
    }
}
