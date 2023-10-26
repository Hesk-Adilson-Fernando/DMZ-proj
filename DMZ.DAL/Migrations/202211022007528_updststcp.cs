namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updststcp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stcp", "Totall", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.St", "Valor", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.Stcp", "quantcp", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            AlterColumn("dbo.Stcp", "Precocp", c => c.Decimal(nullable: false, precision: 10, scale: 2));
            DropColumn("dbo.Stcp", "stkprod");
            DropColumn("dbo.Stcp", "refstk");
            DropColumn("dbo.Stcp", "refst");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stcp", "refst", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Stcp", "refstk", c => c.Boolean(nullable: false));
            AddColumn("dbo.Stcp", "stkprod", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Stcp", "Precocp", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Stcp", "quantcp", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.St", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Stcp", "Totall");
        }
    }
}
