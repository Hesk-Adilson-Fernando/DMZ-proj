namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADICONACAMPO2CAIXAL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caixal", "Campo2", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Caixal", "Campo3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Obs", c => c.String(nullable: false, maxLength: 600));
            AddColumn("dbo.Caixal", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Turno", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Turnostamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Caixal", "Turnostamp");
            DropColumn("dbo.Caixal", "Turno");
            DropColumn("dbo.Caixal", "Contasstamp");
            DropColumn("dbo.Caixal", "Obs");
            DropColumn("dbo.Caixal", "Campo3");
            DropColumn("dbo.Caixal", "Campo2");
        }
    }
}
