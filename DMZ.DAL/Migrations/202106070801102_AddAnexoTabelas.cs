namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnexoTabelas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dil3", "Distamp", "dbo.Di");
            DropForeignKey("dbo.Docmodulo", "Tpgfstamp", "dbo.Tpgf");
            DropForeignKey("dbo.Docmodulo", "Trclstamp", "dbo.TRcl");
            DropForeignKey("dbo.Docmodulo", "Trdstamp", "dbo.Trd");
            DropForeignKey("dbo.Docmodulo", "Trdfstamp", "dbo.Trdf");
            DropForeignKey("dbo.Docmodulo", "Rltstamp", "dbo.Rlt");
            DropForeignKey("dbo.Docmodulo", "Tdistamp", "dbo.Tdi");
            DropForeignKey("dbo.Docmodulo", "Tdocstamp", "dbo.Tdoc");
            DropForeignKey("dbo.Docmodulo", "Tdocfstamp", "dbo.Tdocf");
            DropIndex("dbo.Dil3", new[] { "Distamp" });
            DropIndex("dbo.Docmodulo", new[] { "Rltstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdistamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdocstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Trclstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Trdstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdocfstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tpgfstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Trdfstamp" });
            CreateTable(
                "dbo.Dianexo",
                c => new
                    {
                        Dianexostamp = c.String(nullable: false, maxLength: 80),
                        Distamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Anexo = c.Binary(),
                    })
                .PrimaryKey(t => t.Dianexostamp)
                .ForeignKey("dbo.Di", t => t.Distamp, cascadeDelete: true)
                .Index(t => t.Distamp);
            
            CreateTable(
                "dbo.Faccanexo",
                c => new
                    {
                        Faccanexostamp = c.String(nullable: false, maxLength: 80),
                        Faccstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Anexo = c.Binary(),
                        Di_Distamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Faccanexostamp)
                .ForeignKey("dbo.Di", t => t.Di_Distamp)
                .Index(t => t.Di_Distamp);
            
            CreateTable(
                "dbo.Factanexo",
                c => new
                    {
                        Factanexostamp = c.String(nullable: false, maxLength: 80),
                        Factstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Anexo = c.Binary(),
                        Di_Distamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Factanexostamp)
                .ForeignKey("dbo.Di", t => t.Di_Distamp)
                .Index(t => t.Di_Distamp);
            
            AlterColumn("dbo.Docmodulo", "Rltstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Docmodulo", "Tdistamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Docmodulo", "Tdocstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Docmodulo", "Tdocfstamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Docmodulo", "Rltstamp");
            CreateIndex("dbo.Docmodulo", "Tdistamp");
            CreateIndex("dbo.Docmodulo", "Tdocstamp");
            CreateIndex("dbo.Docmodulo", "Tdocfstamp");
            AddForeignKey("dbo.Docmodulo", "Rltstamp", "dbo.Rlt", "Rltstamp");
            AddForeignKey("dbo.Docmodulo", "Tdistamp", "dbo.Tdi", "Tdistamp");
            AddForeignKey("dbo.Docmodulo", "Tdocstamp", "dbo.Tdoc", "Tdocstamp");
            AddForeignKey("dbo.Docmodulo", "Tdocfstamp", "dbo.Tdocf", "Tdocfstamp");
            DropColumn("dbo.Docmodulo", "Trclstamp");
            DropColumn("dbo.Docmodulo", "Trdstamp");
            DropColumn("dbo.Docmodulo", "Tpgfstamp");
            DropColumn("dbo.Docmodulo", "Trdfstamp");
            DropTable("dbo.Dil3");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Dil3",
                c => new
                    {
                        Dil3Stamp = c.String(nullable: false, maxLength: 80),
                        Cod = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Distamp = c.String(nullable: false, maxLength: 80),
                        Intertekstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Dil3Stamp);
            
            AddColumn("dbo.Docmodulo", "Trdfstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Docmodulo", "Tpgfstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Docmodulo", "Trdstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Docmodulo", "Trclstamp", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Docmodulo", "Tdocfstamp", "dbo.Tdocf");
            DropForeignKey("dbo.Docmodulo", "Tdocstamp", "dbo.Tdoc");
            DropForeignKey("dbo.Docmodulo", "Tdistamp", "dbo.Tdi");
            DropForeignKey("dbo.Docmodulo", "Rltstamp", "dbo.Rlt");
            DropForeignKey("dbo.Factanexo", "Di_Distamp", "dbo.Di");
            DropForeignKey("dbo.Faccanexo", "Di_Distamp", "dbo.Di");
            DropForeignKey("dbo.Dianexo", "Distamp", "dbo.Di");
            DropIndex("dbo.Factanexo", new[] { "Di_Distamp" });
            DropIndex("dbo.Faccanexo", new[] { "Di_Distamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdocfstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdocstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdistamp" });
            DropIndex("dbo.Docmodulo", new[] { "Rltstamp" });
            DropIndex("dbo.Dianexo", new[] { "Distamp" });
            AlterColumn("dbo.Docmodulo", "Tdocfstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Docmodulo", "Tdocstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Docmodulo", "Tdistamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Docmodulo", "Rltstamp", c => c.String(nullable: false, maxLength: 80));
            DropTable("dbo.Factanexo");
            DropTable("dbo.Faccanexo");
            DropTable("dbo.Dianexo");
            CreateIndex("dbo.Docmodulo", "Trdfstamp");
            CreateIndex("dbo.Docmodulo", "Tpgfstamp");
            CreateIndex("dbo.Docmodulo", "Tdocfstamp");
            CreateIndex("dbo.Docmodulo", "Trdstamp");
            CreateIndex("dbo.Docmodulo", "Trclstamp");
            CreateIndex("dbo.Docmodulo", "Tdocstamp");
            CreateIndex("dbo.Docmodulo", "Tdistamp");
            CreateIndex("dbo.Docmodulo", "Rltstamp");
            CreateIndex("dbo.Dil3", "Distamp");
            AddForeignKey("dbo.Docmodulo", "Tdocfstamp", "dbo.Tdocf", "Tdocfstamp", cascadeDelete: true);
            AddForeignKey("dbo.Docmodulo", "Tdocstamp", "dbo.Tdoc", "Tdocstamp", cascadeDelete: true);
            AddForeignKey("dbo.Docmodulo", "Tdistamp", "dbo.Tdi", "Tdistamp", cascadeDelete: true);
            AddForeignKey("dbo.Docmodulo", "Rltstamp", "dbo.Rlt", "Rltstamp", cascadeDelete: true);
            AddForeignKey("dbo.Docmodulo", "Trdfstamp", "dbo.Trdf", "Trdfstamp", cascadeDelete: true);
            AddForeignKey("dbo.Docmodulo", "Trdstamp", "dbo.Trd", "Trdstamp", cascadeDelete: true);
            AddForeignKey("dbo.Docmodulo", "Trclstamp", "dbo.TRcl", "TRclstamp", cascadeDelete: true);
            AddForeignKey("dbo.Docmodulo", "Tpgfstamp", "dbo.Tpgf", "Tpgfstamp", cascadeDelete: true);
            AddForeignKey("dbo.Dil3", "Distamp", "dbo.Di", "Distamp", cascadeDelete: true);
        }
    }
}
