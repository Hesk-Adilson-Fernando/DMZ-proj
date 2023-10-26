namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipiuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "TipoAcesso", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "TipoAcesso");
        }
    }
}
