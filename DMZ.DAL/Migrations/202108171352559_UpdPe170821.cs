namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPe170821 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pe", "Diasmes", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pe", "HorasSemana", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pe", "SalHora", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pe", "SalHora", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pe", "HorasSemana", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pe", "Diasmes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
