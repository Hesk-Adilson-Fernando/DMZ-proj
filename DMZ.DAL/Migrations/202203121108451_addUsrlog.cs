namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsrlog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsrLog",
                c => new
                    {
                        UsrLogstamp = c.String(nullable: false, maxLength: 80),
                        Usrstamp = c.String(nullable: false, maxLength: 80),
                        EntradaDataHora = c.DateTime(nullable: false),
                        SaidaDataHora = c.DateTime(nullable: false),
                        FirstLogin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UsrLogstamp)
                .ForeignKey("dbo.Usr", t => t.Usrstamp, cascadeDelete: true)
                .Index(t => t.Usrstamp);
            
            AddColumn("dbo.Usr", "Usanormal", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Impnormal", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Imppos", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsrLog", "Usrstamp", "dbo.Usr");
            DropIndex("dbo.UsrLog", new[] { "Usrstamp" });
            DropColumn("dbo.Usr", "Imppos");
            DropColumn("dbo.Usr", "Impnormal");
            DropColumn("dbo.Usr", "Usanormal");
            DropTable("dbo.UsrLog");
        }
    }
}
