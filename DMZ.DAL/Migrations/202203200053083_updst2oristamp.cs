namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updst2oristamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St2", "Origem", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Oristamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Cambio", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.St2", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.St2", "Motivo", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.St2", "Grupo", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.St2", "Subgrupo", c => c.String(nullable: false, maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.St2", "Subgrupo", c => c.String(nullable: false));
            AlterColumn("dbo.St2", "Grupo", c => c.String(nullable: false));
            AlterColumn("dbo.St2", "Motivo", c => c.String(nullable: false));
            DropColumn("dbo.St2", "Moeda");
            DropColumn("dbo.St2", "Cambio");
            DropColumn("dbo.St2", "Oristamp");
            DropColumn("dbo.St2", "Origem");
        }
    }
}
