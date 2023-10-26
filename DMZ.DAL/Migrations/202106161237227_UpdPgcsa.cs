namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPgcsa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pgf", "Total", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pgf", "Mtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pgf", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pgcsa", "Deb", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pgcsa", "Cre", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pgcsa", "Cre", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgcsa", "Deb", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgf", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.Pgf", "Mtotal", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.Pgf", "Total", c => c.Decimal(nullable: false, precision: 16, scale: 0));
        }
    }
}
