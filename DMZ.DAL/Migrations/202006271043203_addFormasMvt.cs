namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFormasMvt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formasp", "UsrLogin", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mvt", "UsrLogin", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Teste", "descricao2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Teste", "Descricao2", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teste", "Descricao2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Teste", "descricao2", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Mvt", "UsrLogin");
            DropColumn("dbo.Formasp", "UsrLogin");
        }
    }
}
