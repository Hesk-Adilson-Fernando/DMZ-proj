namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addClCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClCart",
                c => new
                    {
                        ClCartstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Datavenc = c.DateTime(nullable: false),
                        Produzido = c.Boolean(nullable: false),
                        Entregue = c.Boolean(nullable: false),
                        Dataentrega = c.DateTime(nullable: false),
                        Usrentrega = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.ClCartstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            AddColumn("dbo.Cl", "Codigobarra", c => c.Binary());
            AddColumn("dbo.Cl", "CodigoQr", c => c.Binary());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClCart", "Clstamp", "dbo.Cl");
            DropIndex("dbo.ClCart", new[] { "Clstamp" });
            DropColumn("dbo.Cl", "CodigoQr");
            DropColumn("dbo.Cl", "Codigobarra");
            DropTable("dbo.ClCart");
        }
    }
}
