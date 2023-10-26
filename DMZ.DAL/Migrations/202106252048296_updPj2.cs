namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPj2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pj", "TotftIva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pj", "TotCompIva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pj", "Dias", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AlterColumn("dbo.Pj", "No", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Pj", "Trecebido", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pj", "Tpago", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pj", "Orc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pj", "Adenda", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pj", "Adendaper", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AlterColumn("dbo.Pj", "TotComp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pj", "Totft", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pj", "TotGi", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pj", "Lucro", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Pj", "Estado");
            DropColumn("dbo.Pj", "Datfecho");
            DropColumn("dbo.Pj", "Totorc");
            DropColumn("dbo.Pj", "Totftper");
            DropColumn("dbo.Pj", "Totrec");
            DropColumn("dbo.Pj", "Totrecper");
            DropColumn("dbo.Pj", "Totprec");
            DropColumn("dbo.Pj", "Totprecper");
            DropColumn("dbo.Pj", "Totpft");
            DropColumn("dbo.Pj", "Totpftper");
            DropColumn("dbo.Pj", "Lucroper");
            DropColumn("dbo.Pj", "Totpessoal");
            DropColumn("dbo.Pj", "Totvt");
            DropColumn("dbo.Pj", "Totpj");
            DropColumn("dbo.Pj", "Totcusto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pj", "Totcusto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totpj", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totvt", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totpessoal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Lucroper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totpftper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totpft", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totprecper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totprec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totrecper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totrec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totftper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totorc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Datfecho", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pj", "Estado", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Pj", "Lucro", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "TotGi", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "Totft", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "TotComp", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "Adendaper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "Adenda", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "Orc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "Tpago", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "Trecebido", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "Dias", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pj", "TotCompIva");
            DropColumn("dbo.Pj", "TotftIva");
        }
    }
}
