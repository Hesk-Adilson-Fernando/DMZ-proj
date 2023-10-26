namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdData1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pjescl", "Pjescstamp", "dbo.Pjesc");
            DropIndex("dbo.Pjescl", new[] { "Pjescstamp" });
            CreateTable(
                "dbo.PjRh",
                c => new
                    {
                        PjRhstamp = c.String(nullable: false, maxLength: 80),
                        Referencia = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Funcao = c.String(nullable: false, maxLength: 80),
                        Custo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dataini = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                        Dias = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ValBasico = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.PjRhstamp)
                .ForeignKey("dbo.Pj", t => t.Pjstamp, cascadeDelete: true)
                .Index(t => t.Pjstamp);
            
            AddColumn("dbo.Pj", "TRecebido", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "TPago", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "TotComp", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "TotGI", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "DatIniReal", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pj", "DiasReais", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Duracao", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.Pjesc", "Predecedora", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "No", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "NoEscodido", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "DatIniReal", c => c.DateTime());
            AddColumn("dbo.Pjesc", "DatTerminoReal", c => c.DateTime());
            AddColumn("dbo.Pjesc", "DiasReais", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Encerrado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pjesc", "Factura", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pjesc", "Estado", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Executado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pjesc", "Noedita", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Tcusto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Orc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Adenda", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Adendaper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totorc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totft", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totftper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totrec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totrecper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totprec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totprecper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totpft", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totpftper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Lucro", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Lucroper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "RH", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Inicio", c => c.DateTime());
            AddColumn("dbo.Pjesc", "Pretermino", c => c.DateTime());
            AddColumn("dbo.Pjesc", "Termino", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PjRh", "Pjstamp", "dbo.Pj");
            DropIndex("dbo.PjRh", new[] { "Pjstamp" });
            DropColumn("dbo.Pjesc", "Termino");
            DropColumn("dbo.Pjesc", "Pretermino");
            DropColumn("dbo.Pjesc", "Inicio");
            DropColumn("dbo.Pjesc", "RH");
            DropColumn("dbo.Pjesc", "Lucroper");
            DropColumn("dbo.Pjesc", "Lucro");
            DropColumn("dbo.Pjesc", "Totpftper");
            DropColumn("dbo.Pjesc", "Totpft");
            DropColumn("dbo.Pjesc", "Totprecper");
            DropColumn("dbo.Pjesc", "Totprec");
            DropColumn("dbo.Pjesc", "Totrecper");
            DropColumn("dbo.Pjesc", "Totrec");
            DropColumn("dbo.Pjesc", "Totftper");
            DropColumn("dbo.Pjesc", "Totft");
            DropColumn("dbo.Pjesc", "Totorc");
            DropColumn("dbo.Pjesc", "Adendaper");
            DropColumn("dbo.Pjesc", "Adenda");
            DropColumn("dbo.Pjesc", "Orc");
            DropColumn("dbo.Pjesc", "Tcusto");
            DropColumn("dbo.Pjesc", "Noedita");
            DropColumn("dbo.Pjesc", "Executado");
            DropColumn("dbo.Pjesc", "Estado");
            DropColumn("dbo.Pjesc", "Factura");
            DropColumn("dbo.Pjesc", "Encerrado");
            DropColumn("dbo.Pjesc", "DiasReais");
            DropColumn("dbo.Pjesc", "DatTerminoReal");
            DropColumn("dbo.Pjesc", "DatIniReal");
            DropColumn("dbo.Pjesc", "NoEscodido");
            DropColumn("dbo.Pjesc", "No");
            DropColumn("dbo.Pjesc", "Predecedora");
            DropColumn("dbo.Pjesc", "Duracao");
            DropColumn("dbo.Pj", "DiasReais");
            DropColumn("dbo.Pj", "DatIniReal");
            DropColumn("dbo.Pj", "TotGI");
            DropColumn("dbo.Pj", "TotComp");
            DropColumn("dbo.Pj", "TPago");
            DropColumn("dbo.Pj", "TRecebido");
            DropTable("dbo.PjRh");
            CreateIndex("dbo.Pjescl", "Pjescstamp");
            AddForeignKey("dbo.Pjescl", "Pjescstamp", "dbo.Pjesc", "Pjescstamp", cascadeDelete: true);
        }
    }
}
