namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTirpsl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tirpsl", "ValMin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Tirpsl", "ValMax", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Tirpsl", "Dep00", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Tirpsl", "Dep01", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Tirpsl", "Dep02", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Tirpsl", "Dep03", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Tirpsl", "Dep04", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tirpsl", "Dep04", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Tirpsl", "Dep03", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Tirpsl", "Dep02", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Tirpsl", "Dep01", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Tirpsl", "Dep00", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Tirpsl", "ValMax", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Tirpsl", "ValMin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
