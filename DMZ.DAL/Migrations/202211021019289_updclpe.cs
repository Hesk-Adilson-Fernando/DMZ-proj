namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updclpe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClFilial",
                c => new
                    {
                        ClFilialstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Oristamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.ClFilialstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            AddColumn("dbo.Cl", "Possuifilial", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Tirpsstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClFilial", "Clstamp", "dbo.Cl");
            DropIndex("dbo.ClFilial", new[] { "Clstamp" });
            DropColumn("dbo.Pe", "Tirpsstamp");
            DropColumn("dbo.Cl", "Possuifilial");
            DropTable("dbo.ClFilial");
        }
    }
}
