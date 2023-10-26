namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClFam",
                c => new
                    {
                        ClFamstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Grau = c.String(nullable: false, maxLength: 80),
                        Tel = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.ClFamstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            CreateTable(
                "dbo.ClTurma",
                c => new
                    {
                        ClTurmastamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Turma = c.String(nullable: false, maxLength: 80),
                        Classe = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        Docente = c.String(nullable: false, maxLength: 80),
                        Coddoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sala = c.String(nullable: false, maxLength: 80),
                        Codsala = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.ClTurmastamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            AddColumn("dbo.Cl", "Codprov", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Coddist", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Codpad", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Codcurso", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Curso", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Anoingresso", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cl", "CodInst", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Instbolsa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Tipobolsa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Bolseiro", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "Codsem", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Semestre", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Coddep", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Departamento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Codfac", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Faculdade", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Datanasc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cl", "Sexo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Codccu", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Ccusto", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClTurma", "Clstamp", "dbo.Cl");
            DropForeignKey("dbo.ClFam", "Clstamp", "dbo.Cl");
            DropIndex("dbo.ClTurma", new[] { "Clstamp" });
            DropIndex("dbo.ClFam", new[] { "Clstamp" });
            DropColumn("dbo.Cl", "Ccusto");
            DropColumn("dbo.Cl", "Codccu");
            DropColumn("dbo.Cl", "Sexo");
            DropColumn("dbo.Cl", "Datanasc");
            DropColumn("dbo.Cl", "Faculdade");
            DropColumn("dbo.Cl", "Codfac");
            DropColumn("dbo.Cl", "Departamento");
            DropColumn("dbo.Cl", "Coddep");
            DropColumn("dbo.Cl", "Semestre");
            DropColumn("dbo.Cl", "Codsem");
            DropColumn("dbo.Cl", "Bolseiro");
            DropColumn("dbo.Cl", "Tipobolsa");
            DropColumn("dbo.Cl", "Instbolsa");
            DropColumn("dbo.Cl", "CodInst");
            DropColumn("dbo.Cl", "Anoingresso");
            DropColumn("dbo.Cl", "Curso");
            DropColumn("dbo.Cl", "Codcurso");
            DropColumn("dbo.Cl", "Codpad");
            DropColumn("dbo.Cl", "Coddist");
            DropColumn("dbo.Cl", "Codprov");
            DropTable("dbo.ClTurma");
            DropTable("dbo.ClFam");
        }
    }
}
