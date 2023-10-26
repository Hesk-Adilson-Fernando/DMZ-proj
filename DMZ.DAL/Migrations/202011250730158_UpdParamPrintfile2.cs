namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdParamPrintfile2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "NumImpressao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "Printfile", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Param", "Printfile2", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Printfile2");
            DropColumn("dbo.Param", "Printfile");
            DropColumn("dbo.Param", "NumImpressao");
        }
    }
}
