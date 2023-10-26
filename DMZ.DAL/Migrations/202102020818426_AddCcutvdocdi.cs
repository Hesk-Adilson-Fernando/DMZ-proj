namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCcutvdocdi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ccutvdocdi",
                c => new
                    {
                        Ccutvdocdistamp = c.String(nullable: false, maxLength: 80),
                        Ccutvstamp = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ccutvdocdistamp)
                .ForeignKey("dbo.Ccutv", t => t.Ccutvstamp, cascadeDelete: true)
                .Index(t => t.Ccutvstamp)
                .Index(t => t.Sigla, unique: true, name: "IX_X_Ccutvdocdi");
            
            AddColumn("dbo.Ccutvdoc", "Sigla", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ccutvdoc", "Padrao", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Ccutvdoc", "Sigla", unique: true, name: "IX_X_Ccutvdoc");
            CreateIndex("dbo.Tdi", "Sigla", unique: true, name: "IX_X_Tdi");
            CreateIndex("dbo.Tdoc", "Sigla", unique: true, name: "IX_X_Tdoc");
            CreateIndex("dbo.Tdocf", "Sigla", unique: true, name: "IX_X_Tdocf");
            DropColumn("dbo.Ccutvdoc", "Codigo");
            DropColumn("dbo.Ccutvdoc", "Tipodoc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ccutvdoc", "Tipodoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ccutvdoc", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropForeignKey("dbo.Ccutvdocdi", "Ccutvstamp", "dbo.Ccutv");
            DropIndex("dbo.Tdocf", "IX_X_Tdocf");
            DropIndex("dbo.Tdoc", "IX_X_Tdoc");
            DropIndex("dbo.Tdi", "IX_X_Tdi");
            DropIndex("dbo.Ccutvdocdi", "IX_X_Ccutvdocdi");
            DropIndex("dbo.Ccutvdocdi", new[] { "Ccutvstamp" });
            DropIndex("dbo.Ccutvdoc", "IX_X_Ccutvdoc");
            DropColumn("dbo.Ccutvdoc", "Padrao");
            DropColumn("dbo.Ccutvdoc", "Sigla");
            DropTable("dbo.Ccutvdocdi");
        }
    }
}
