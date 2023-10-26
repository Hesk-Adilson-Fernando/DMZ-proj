namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updst2grupos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St2", "Grupo", c => c.String(nullable: false));
            AddColumn("dbo.St2", "Subgrupo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St2", "Subgrupo");
            DropColumn("dbo.St2", "Grupo");
        }
    }
}
