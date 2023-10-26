namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updrtl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "Codccu", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Rlt", "filefrx");
            DropColumn("dbo.Rlt", "filefrt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rlt", "filefrt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "filefrx", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Rlt", "Codccu");
            DropColumn("dbo.Rlt", "Ccusto");
        }
    }
}
