namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updstvt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auxiliar2",
                c => new
                    {
                        Auxiliar2stamp = c.String(nullable: false, maxLength: 80),
                        Auxiliarstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Auxiliar2stamp)
                .ForeignKey("dbo.Auxiliar", t => t.Auxiliarstamp, cascadeDelete: true)
                .Index(t => t.Auxiliarstamp);
            
            CreateTable(
                "dbo.StVtdoc",
                c => new
                    {
                        StVtdocstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.String(nullable: false, maxLength: 80),
                        Tipodoc = c.String(nullable: false, maxLength: 80),
                        Entidade = c.String(nullable: false, maxLength: 80),
                        Datain = c.DateTime(nullable: false),
                        Datatermino = c.DateTime(nullable: false),
                        Anexo = c.Binary(),
                        St_Ststamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.StVtdocstamp)
                .ForeignKey("dbo.St", t => t.St_Ststamp)
                .Index(t => t.St_Ststamp);
            
            CreateTable(
                "dbo.StVtman",
                c => new
                    {
                        StVtmanstamp = c.String(nullable: false, maxLength: 80),
                        Matricula = c.String(nullable: false, maxLength: 80),
                        Valparam = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valkm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diferenca = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Feito = c.Boolean(nullable: false),
                        Distamp = c.String(nullable: false, maxLength: 80),
                        St_Ststamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.StVtmanstamp)
                .ForeignKey("dbo.St", t => t.St_Ststamp)
                .Index(t => t.St_Ststamp);
            
            CreateTable(
                "dbo.StVtTrailer",
                c => new
                    {
                        StVtTrailerstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Matricula = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.StVtTrailerstamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            AddColumn("dbo.St", "Matricula", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Modelo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Motor", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Chassis", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "anofab", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "tara", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "pesobruto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Viatura", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "codtrailer", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Trailer", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.St", "Combustivel", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StVtTrailer", "Ststamp", "dbo.St");
            DropForeignKey("dbo.StVtman", "St_Ststamp", "dbo.St");
            DropForeignKey("dbo.StVtdoc", "St_Ststamp", "dbo.St");
            DropForeignKey("dbo.Auxiliar2", "Auxiliarstamp", "dbo.Auxiliar");
            DropIndex("dbo.StVtTrailer", new[] { "Ststamp" });
            DropIndex("dbo.StVtman", new[] { "St_Ststamp" });
            DropIndex("dbo.StVtdoc", new[] { "St_Ststamp" });
            DropIndex("dbo.Auxiliar2", new[] { "Auxiliarstamp" });
            AlterColumn("dbo.St", "Combustivel", c => c.Boolean(nullable: false));
            DropColumn("dbo.St", "Trailer");
            DropColumn("dbo.St", "codtrailer");
            DropColumn("dbo.St", "Viatura");
            DropColumn("dbo.St", "pesobruto");
            DropColumn("dbo.St", "tara");
            DropColumn("dbo.St", "anofab");
            DropColumn("dbo.St", "Chassis");
            DropColumn("dbo.St", "Motor");
            DropColumn("dbo.St", "Modelo");
            DropColumn("dbo.St", "Matricula");
            DropTable("dbo.StVtTrailer");
            DropTable("dbo.StVtman");
            DropTable("dbo.StVtdoc");
            DropTable("dbo.Auxiliar2");
        }
    }
}
