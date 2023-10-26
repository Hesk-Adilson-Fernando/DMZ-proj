namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTirpsl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tirps",
                c => new
                    {
                        Tirpsstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Tirpsstamp);
            
            CreateTable(
                "dbo.Tirpsl",
                c => new
                    {
                        Tirpslstamp = c.String(nullable: false, maxLength: 80),
                        ValMin = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ValMax = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dep00 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dep01 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dep02 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dep03 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dep04 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Percentagem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tirps_Tirpsstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Tirpslstamp)
                .ForeignKey("dbo.Tirps", t => t.Tirps_Tirpsstamp)
                .Index(t => t.Tirps_Tirpsstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tirpsl", "Tirps_Tirpsstamp", "dbo.Tirps");
            DropIndex("dbo.Tirpsl", new[] { "Tirps_Tirpsstamp" });
            DropTable("dbo.Tirpsl");
            DropTable("dbo.Tirps");
        }
    }
}
