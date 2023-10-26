namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updempresainss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresa", "CodigoINSS", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresa", "CodigoINSS");
        }
    }
}
