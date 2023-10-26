namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updUsr5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "AlteraNumero", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "AlteraNumero");
        }
    }
}
