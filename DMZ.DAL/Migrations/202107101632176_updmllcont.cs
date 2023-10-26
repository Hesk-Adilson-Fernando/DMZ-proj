namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updmllcont : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lcont", "Oristamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Oristampl", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Ml", "Obs", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Lcont", "Qmc");
            DropColumn("dbo.Lcont", "Qmcdathora");
            DropColumn("dbo.Lcont", "Qma");
            DropColumn("dbo.Lcont", "Qmadathora");
            DropColumn("dbo.Ml", "Cct");
            DropColumn("dbo.Ml", "Debl");
            DropColumn("dbo.Ml", "Vemdedc");
            DropColumn("dbo.Ml", "Recapit");
            DropColumn("dbo.Ml", "Ncont");
            DropColumn("dbo.Ml", "Recapval");
            DropColumn("dbo.Ml", "Separa");
            DropColumn("dbo.Ml", "Vemdoext");
            DropColumn("dbo.Ml", "Erecapval");
            DropColumn("dbo.Ml", "Lordem");
            DropColumn("dbo.Ml", "Npt");
            DropColumn("dbo.Ml", "Bastamp");
            DropColumn("dbo.Ml", "Intid");
            DropColumn("dbo.Ml", "idorigem");
            DropColumn("dbo.Ml", "reco");
            DropColumn("dbo.Ml", "extracto");
            DropColumn("dbo.Ml", "olcodigo");
            DropColumn("dbo.Ml", "sgrupo");
            DropColumn("dbo.Ml", "grupo");
            DropColumn("dbo.Ml", "debm");
            DropColumn("dbo.Ml", "crem");
            DropColumn("dbo.Ml", "pncont");
            DropColumn("dbo.Ml", "conf1");
            DropColumn("dbo.Ml", "conf2");
            DropColumn("dbo.Ml", "codis");
            DropColumn("dbo.Ml", "czonag");
            DropColumn("dbo.Ml", "codisconf");
            DropColumn("dbo.Ml", "Chave");
            DropColumn("dbo.Ml", "numcontrepres");
            DropColumn("dbo.Ml", "codprovincia");
            DropColumn("dbo.Ml", "cambio");
            DropColumn("dbo.Ml", "paistamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ml", "paistamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "cambio", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Ml", "codprovincia", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "numcontrepres", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Chave", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "codisconf", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "czonag", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "codis", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "conf2", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "conf1", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "pncont", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "crem", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Ml", "debm", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Ml", "grupo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "sgrupo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "olcodigo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "extracto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "reco", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "idorigem", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Ml", "Intid", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Bastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Npt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Lordem", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Ml", "Erecapval", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Ml", "Vemdoext", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "Separa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "Recapval", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Ml", "Ncont", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Recapit", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Vemdedc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "Debl", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "Cct", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Lcont", "Qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Lcont", "Qma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Lcont", "Qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Lcont", "Qmc", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Ml", "Obs", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Ml", "Oristampl");
            DropColumn("dbo.Lcont", "Oristamp");
        }
    }
}
