namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTdocF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdocf", "Coment", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Dias", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdocf", "Dias");
            DropColumn("dbo.Tdocf", "Coment");
        }
    }
}
