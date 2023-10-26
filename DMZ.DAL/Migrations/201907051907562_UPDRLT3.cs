namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDRLT3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rlt", "ComboQry1", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "tmGrid", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "clmMask", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "clnHeader", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "clnCor", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "ComboQry2", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "ComboQry3", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "ComboQry4", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "ComboQry5", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "ComboQry6", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "ComboQry7", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "ComboQry8", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "ComboQry9", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "filtros", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rlt", "filtros", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry9", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry8", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry7", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry6", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry5", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry4", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry3", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "clnCor", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "clnHeader", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "clmMask", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "tmGrid", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "ComboQry1", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
