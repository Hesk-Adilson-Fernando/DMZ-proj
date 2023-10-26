namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFamliacrlMatricula : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Familiacarl", "Matricula", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Familiacarl", "Matricula");
        }
    }
}
