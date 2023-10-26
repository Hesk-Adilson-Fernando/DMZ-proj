namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mostracurso : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prc", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "Mostracurso", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rlt", "Mostracurso");
            DropColumn("dbo.Prc", "Ccustamp");
        }
    }
}
