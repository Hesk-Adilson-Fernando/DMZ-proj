namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPeaus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Peaus",
                c => new
                    {
                        Peausstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Datain = c.DateTime(nullable: false),
                        Datater = c.DateTime(nullable: false),
                        Processa = c.Boolean(nullable: false),
                        Cancelada = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Peausstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            AddColumn("dbo.Rlt", "Codmodulo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "Modulo", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Peaus", "Pestamp", "dbo.Pe");
            DropIndex("dbo.Peaus", new[] { "Pestamp" });
            DropColumn("dbo.Rlt", "Modulo");
            DropColumn("dbo.Rlt", "Codmodulo");
            DropTable("dbo.Peaus");
        }
    }
}
