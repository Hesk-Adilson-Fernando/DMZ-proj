namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPgc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pgc", "Dedutivel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "Liquidado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "oristamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "Moviva", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "activo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pgc", "activo");
            DropColumn("dbo.Pgc", "Moviva");
            DropColumn("dbo.Pgc", "oristamp");
            DropColumn("dbo.Pgc", "Liquidado");
            DropColumn("dbo.Pgc", "Dedutivel");
        }
    }
}
