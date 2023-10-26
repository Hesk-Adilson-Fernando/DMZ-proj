namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updpjusr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PjAudit",
                c => new
                    {
                        Pjauditstamp = c.String(nullable: false, maxLength: 80),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Comprado = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vendido = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Interno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Login = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pjauditstamp)
                .ForeignKey("dbo.Pj", t => t.Pjstamp, cascadeDelete: true)
                .Index(t => t.Pjstamp);
            
            AddColumn("dbo.Pj", "Fechado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pj", "Fechadodata", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usr", "ReabrePj", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PjAudit", "Pjstamp", "dbo.Pj");
            DropIndex("dbo.PjAudit", new[] { "Pjstamp" });
            DropColumn("dbo.Usr", "ReabrePj");
            DropColumn("dbo.Pj", "Fechadodata");
            DropColumn("dbo.Pj", "Fechado");
            DropTable("dbo.PjAudit");
        }
    }
}
