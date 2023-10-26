namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterapgc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pgc", "Numero", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pgc", "Dbcr");
            DropColumn("dbo.Pgc", "Dbdb");
            DropColumn("dbo.Pgc", "Crdb");
            DropColumn("dbo.Pgc", "Crcr");
            DropColumn("dbo.Pgc", "multicc");
            DropColumn("dbo.Pgc", "qualci");
            DropColumn("dbo.Pgc", "recapit");
            DropColumn("dbo.Pgc", "local");
            DropColumn("dbo.Pgc", "contado");
            DropColumn("dbo.Pgc", "ollocal");
            DropColumn("dbo.Pgc", "lancaol");
            DropColumn("dbo.Pgc", "servcee");
            DropColumn("dbo.Pgc", "obrigacc");
            DropColumn("dbo.Pgc", "obrigaol");
            DropColumn("dbo.Pgc", "ppdesc");
            DropColumn("dbo.Pgc", "obriganc");
            DropColumn("dbo.Pgc", "olmoeda");
            DropColumn("dbo.Pgc", "doabrebe");
            DropColumn("dbo.Pgc", "pme");
            DropColumn("dbo.Pgc", "marcada");
            DropColumn("dbo.Pgc", "qmc");
            DropColumn("dbo.Pgc", "qmcdathora");
            DropColumn("dbo.Pgc", "qma");
            DropColumn("dbo.Pgc", "qmadathora");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pgc", "qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pgc", "qma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pgc", "qmc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "marcada", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "pme", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "doabrebe", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "olmoeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "obriganc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "ppdesc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "obrigaol", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "obrigacc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "servcee", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "lancaol", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "ollocal", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "contado", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pgc", "local", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "recapit", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "qualci", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "multicc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgc", "Crcr", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "Crdb", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "Dbdb", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgc", "Dbcr", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Pgc", "Numero");
        }
    }
}
