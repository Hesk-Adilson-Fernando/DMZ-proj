namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updRelat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "Pos", c => c.Boolean(nullable: false));
            DropColumn("dbo.Rlt", "qmc");
            DropColumn("dbo.Rlt", "qmcdathora");
            DropColumn("dbo.Rlt", "qma");
            DropColumn("dbo.Rlt", "qmadathora");
            DropColumn("dbo.Rlt", "Lista");
            DropColumn("dbo.Rlt", "usaca");
            DropColumn("dbo.Rlt", "tmColunas");
            DropColumn("dbo.Rlt", "menuint");
            DropColumn("dbo.Rlt", "painel");
            DropColumn("dbo.Rlt", "btncriadoc");
            DropColumn("dbo.Rlt", "btndestino");
            DropColumn("dbo.Rlt", "btnorigem");
            DropColumn("dbo.Rlt", "ecran");
            DropColumn("dbo.Rlt", "campotabela2");
            DropColumn("dbo.Rlt", "Titlocal2");
            DropColumn("dbo.Rlt", "campotabela3");
            DropColumn("dbo.Rlt", "Titlocal3");
            DropColumn("dbo.Rlt", "campotabela4");
            DropColumn("dbo.Rlt", "Titlocal4");
            DropColumn("dbo.Rlt", "campotabela5");
            DropColumn("dbo.Rlt", "Titlocal5");
            DropColumn("dbo.Rlt", "campotabela6");
            DropColumn("dbo.Rlt", "Titlocal6");
            DropColumn("dbo.Rlt", "campotabela7");
            DropColumn("dbo.Rlt", "Titlocal7");
            DropColumn("dbo.Rlt", "campotabela8");
            DropColumn("dbo.Rlt", "Titlocal8");
            DropColumn("dbo.Rlt", "campotabela9");
            DropColumn("dbo.Rlt", "Titlocal9");
            DropColumn("dbo.Rlt", "titlocal1");
            DropColumn("dbo.Rlt", "codcampo1");
            DropColumn("dbo.Rlt", "mascampo1");
            DropColumn("dbo.Rlt", "codcampo2");
            DropColumn("dbo.Rlt", "mascampo2");
            DropColumn("dbo.Rlt", "codcampo3");
            DropColumn("dbo.Rlt", "mascampo3");
            DropColumn("dbo.Rlt", "codcampo4");
            DropColumn("dbo.Rlt", "mascampo4");
            DropColumn("dbo.Rlt", "codcampo5");
            DropColumn("dbo.Rlt", "mascampo5");
            DropColumn("dbo.Rlt", "codcampo6");
            DropColumn("dbo.Rlt", "mascampo6");
            DropColumn("dbo.Rlt", "codcampo7");
            DropColumn("dbo.Rlt", "mascampo7");
            DropColumn("dbo.Rlt", "codcampo8");
            DropColumn("dbo.Rlt", "mascampo8");
            DropColumn("dbo.Rlt", "codcampo9");
            DropColumn("dbo.Rlt", "mascampo9");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rlt", "mascampo9", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo9", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "mascampo8", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo8", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "mascampo7", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo7", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "mascampo6", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo6", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "mascampo5", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo5", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "mascampo4", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo4", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "mascampo3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo3", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "mascampo2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "mascampo1", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "codcampo1", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "titlocal1", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "Titlocal9", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "campotabela9", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Titlocal8", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "campotabela8", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Titlocal7", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "campotabela7", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Titlocal6", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "campotabela6", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Titlocal5", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "campotabela5", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Titlocal4", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "campotabela4", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Titlocal3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "campotabela3", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Titlocal2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "campotabela2", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "ecran", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "btnorigem", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "btndestino", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "btncriadoc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "painel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "menuint", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "tmColunas", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "usaca", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Lista", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rlt", "qma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rlt", "qmc", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Rlt", "Pos");
        }
    }
}
