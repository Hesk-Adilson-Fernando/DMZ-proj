namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updProcurment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProcAnalFnc", "Fncstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ProcAnalFnc", "Email", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ProcAnalFnc", "Ststamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurm", "Clstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "Fncstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "Activo", c => c.Boolean());
            AddColumn("dbo.Procurml", "Ststamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "Pjescstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "CCusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "CodCCu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "Entidadestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Procurml", "Cambiousd", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Procurml", "Mvalival", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Procurml", "Mdescontol", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Procurml", "Msubtotall", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Procurml", "Mtotall", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Procurml", "Mtotall");
            DropColumn("dbo.Procurml", "Msubtotall");
            DropColumn("dbo.Procurml", "Mdescontol");
            DropColumn("dbo.Procurml", "Mvalival");
            DropColumn("dbo.Procurml", "Cambiousd");
            DropColumn("dbo.Procurml", "Moeda2");
            DropColumn("dbo.Procurml", "Moeda");
            DropColumn("dbo.Procurml", "Entidadestamp");
            DropColumn("dbo.Procurml", "CodCCu");
            DropColumn("dbo.Procurml", "CCusto");
            DropColumn("dbo.Procurml", "Pjescstamp");
            DropColumn("dbo.Procurml", "Ststamp");
            DropColumn("dbo.Procurml", "Activo");
            DropColumn("dbo.Procurml", "Fncstamp");
            DropColumn("dbo.Procurm", "Clstamp");
            DropColumn("dbo.ProcAnalFnc", "Ststamp");
            DropColumn("dbo.ProcAnalFnc", "Email");
            DropColumn("dbo.ProcAnalFnc", "Fncstamp");
        }
    }
}
