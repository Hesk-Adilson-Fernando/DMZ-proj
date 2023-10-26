namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Verifacaermigrat1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TdocMat",
                c => new
                    {
                        TdocMatstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Defa = c.Boolean(nullable: false),
                        Inscricao = c.Boolean(nullable: false),
                        Matricula = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TdocMatstamp)
                .Index(t => t.Sigla, unique: true, name: "IX_X_Tdoc");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TdocMat", "IX_X_Tdoc");
            DropTable("dbo.TdocMat");
        }
    }
}
