namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRdlXml : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rdlcxml", "Descricao", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rdlcxml", "Descricao");
        }
    }
}
