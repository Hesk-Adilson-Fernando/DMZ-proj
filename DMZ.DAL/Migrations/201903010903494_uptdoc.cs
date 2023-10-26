namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uptdoc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdoc", "Padrao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Noneg", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Codarm", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdoc", "Armazem", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdoc", "Armazem");
            DropColumn("dbo.Tdoc", "Codarm");
            DropColumn("dbo.Tdoc", "Noneg");
            DropColumn("dbo.Tdoc", "Padrao");
        }
    }
}
