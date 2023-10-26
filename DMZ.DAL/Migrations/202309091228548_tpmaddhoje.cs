namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tpmaddhoje : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caixal", "MobileUnicNumber", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "SerialNumber", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Corredor", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Corredorstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Carreirastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Carreira", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Matricula", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Viaturastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Mobileserial", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.UsrLog", "Corredor", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Corredorstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Sentidostamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Sentido", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Carreira", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Cobradorstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Estado", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.UsrLog", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.UsrLog", "Matricula", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Viaturastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrLog", "Carreirastamp", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Caixal", "Campo2");
            DropColumn("dbo.Caixal", "Campo3");
            DropColumn("dbo.Caixal", "Obs");
            DropColumn("dbo.Caixal", "Contasstamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Caixal", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Obs", c => c.String(nullable: false, maxLength: 600));
            AddColumn("dbo.Caixal", "Campo3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Campo2", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.UsrLog", "Carreirastamp");
            DropColumn("dbo.UsrLog", "Viaturastamp");
            DropColumn("dbo.UsrLog", "Matricula");
            DropColumn("dbo.UsrLog", "Codigo");
            DropColumn("dbo.UsrLog", "Estado");
            DropColumn("dbo.UsrLog", "Cobradorstamp");
            DropColumn("dbo.UsrLog", "Carreira");
            DropColumn("dbo.UsrLog", "Sentido");
            DropColumn("dbo.UsrLog", "Sentidostamp");
            DropColumn("dbo.UsrLog", "Corredorstamp");
            DropColumn("dbo.UsrLog", "Corredor");
            DropColumn("dbo.UsrLog", "Valor");
            DropColumn("dbo.Caixal", "Mobileserial");
            DropColumn("dbo.Caixal", "Viaturastamp");
            DropColumn("dbo.Caixal", "Matricula");
            DropColumn("dbo.Caixal", "Carreira");
            DropColumn("dbo.Caixal", "Carreirastamp");
            DropColumn("dbo.Caixal", "Corredorstamp");
            DropColumn("dbo.Caixal", "Corredor");
            DropColumn("dbo.Caixal", "SerialNumber");
            DropColumn("dbo.Caixal", "MobileUnicNumber");
        }
    }
}
