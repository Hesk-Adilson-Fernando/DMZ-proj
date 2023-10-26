namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updmtv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mvt", "Numcaixa", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Mvt", "Datcaixa", c => c.DateTime(nullable: false));
            AddColumn("dbo.Mvt", "Fechado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mvt", "Inicial", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Mvt", "Numero", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mvt", "Numero");
            DropColumn("dbo.Mvt", "Inicial");
            DropColumn("dbo.Mvt", "Fechado");
            DropColumn("dbo.Mvt", "Datcaixa");
            DropColumn("dbo.Mvt", "Numcaixa");
        }
    }
}
