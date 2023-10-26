namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updmvtcod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mvt", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Mvt", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mvt", "Descmovtz");
            DropColumn("dbo.Mvt", "Codmovtz");
        }
    }
}
