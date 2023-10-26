namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addInscricao2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdoc", "Inscricao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdoc", "Inscricao");
        }
    }
}
