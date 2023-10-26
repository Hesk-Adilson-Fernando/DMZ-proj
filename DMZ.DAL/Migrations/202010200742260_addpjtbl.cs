namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpjtbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pjclpe",
                c => new
                    {
                        Pjclpestamp = c.String(nullable: false, maxLength: 80),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Funcao = c.String(nullable: false, maxLength: 80),
                        Telefone = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pjclpestamp)
                .ForeignKey("dbo.Pj", t => t.Pjstamp, cascadeDelete: true)
                .Index(t => t.Pjstamp);
            
            CreateTable(
                "dbo.Pjdepart",
                c => new
                    {
                        Pjdepartstamp = c.String(nullable: false, maxLength: 80),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Resp = c.String(nullable: false, maxLength: 600),
                    })
                .PrimaryKey(t => t.Pjdepartstamp)
                .ForeignKey("dbo.Pj", t => t.Pjstamp, cascadeDelete: true)
                .Index(t => t.Pjstamp);
            
            CreateTable(
                "dbo.Pjesc",
                c => new
                    {
                        Pjescstamp = c.String(nullable: false, maxLength: 80),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 600),
                    })
                .PrimaryKey(t => t.Pjescstamp)
                .ForeignKey("dbo.Pj", t => t.Pjstamp, cascadeDelete: true)
                .Index(t => t.Pjstamp);
            
            CreateTable(
                "dbo.Pjescl",
                c => new
                    {
                        Pjesclstamp = c.String(nullable: false, maxLength: 80),
                        Pjescstamp = c.String(nullable: false, maxLength: 80),
                        Actividade = c.String(nullable: false, maxLength: 800),
                        Resp = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Pretermino = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                        Perc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Factura = c.Boolean(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 600),
                        Pj_Pjstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Pjesclstamp)
                .ForeignKey("dbo.Pj", t => t.Pj_Pjstamp)
                .ForeignKey("dbo.Pjesc", t => t.Pjescstamp, cascadeDelete: true)
                .Index(t => t.Pjescstamp)
                .Index(t => t.Pj_Pjstamp);
            
            CreateTable(
                "dbo.Pjdoc",
                c => new
                    {
                        Pjdocstamp = c.String(nullable: false, maxLength: 80),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 600),
                        Anexo = c.Binary(),
                    })
                .PrimaryKey(t => t.Pjdocstamp)
                .ForeignKey("dbo.Pj", t => t.Pjstamp, cascadeDelete: true)
                .Index(t => t.Pjstamp);
            
            AddColumn("dbo.Pj", "Totpessoal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totvt", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totpj", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Totcusto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Codprov", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Prov", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Coddist", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Dist", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Endereco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjvt", "Referenc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjvt", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjvt", "Custo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjvt", "Quant", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjvt", "Total", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pj", "Status", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Pjvt", "Matricula");
            DropColumn("dbo.Pjvt", "Capacit");
            DropColumn("dbo.Pjvt", "Nviagens");
            DropColumn("dbo.Pjvt", "Totqtt");
            DropColumn("dbo.Pjvt", "Nome");
            DropColumn("dbo.Pjvt", "No");
            DropColumn("dbo.Pjvt", "Status");
            DropColumn("dbo.Pjvt", "Marca");
            DropColumn("dbo.Pjvt", "Tipo");
            DropColumn("dbo.Pjvt", "Valorbase");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pjvt", "Valorbase", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjvt", "Tipo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjvt", "Marca", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjvt", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pjvt", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjvt", "Nome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjvt", "Totqtt", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjvt", "Nviagens", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjvt", "Capacit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjvt", "Matricula", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Pjdoc", "Pjstamp", "dbo.Pj");
            DropForeignKey("dbo.Pjescl", "Pjescstamp", "dbo.Pjesc");
            DropForeignKey("dbo.Pjescl", "Pj_Pjstamp", "dbo.Pj");
            DropForeignKey("dbo.Pjesc", "Pjstamp", "dbo.Pj");
            DropForeignKey("dbo.Pjdepart", "Pjstamp", "dbo.Pj");
            DropForeignKey("dbo.Pjclpe", "Pjstamp", "dbo.Pj");
            DropIndex("dbo.Pjdoc", new[] { "Pjstamp" });
            DropIndex("dbo.Pjescl", new[] { "Pj_Pjstamp" });
            DropIndex("dbo.Pjescl", new[] { "Pjescstamp" });
            DropIndex("dbo.Pjesc", new[] { "Pjstamp" });
            DropIndex("dbo.Pjdepart", new[] { "Pjstamp" });
            DropIndex("dbo.Pjclpe", new[] { "Pjstamp" });
            AlterColumn("dbo.Pj", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Pjvt", "Total");
            DropColumn("dbo.Pjvt", "Quant");
            DropColumn("dbo.Pjvt", "Custo");
            DropColumn("dbo.Pjvt", "Descricao");
            DropColumn("dbo.Pjvt", "Referenc");
            DropColumn("dbo.Pj", "Endereco");
            DropColumn("dbo.Pj", "Dist");
            DropColumn("dbo.Pj", "Coddist");
            DropColumn("dbo.Pj", "Prov");
            DropColumn("dbo.Pj", "Codprov");
            DropColumn("dbo.Pj", "Totcusto");
            DropColumn("dbo.Pj", "Totpj");
            DropColumn("dbo.Pj", "Totvt");
            DropColumn("dbo.Pj", "Totpessoal");
            DropTable("dbo.Pjdoc");
            DropTable("dbo.Pjescl");
            DropTable("dbo.Pjesc");
            DropTable("dbo.Pjdepart");
            DropTable("dbo.Pjclpe");
        }
    }
}
