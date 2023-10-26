namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpgfl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pgfl",
                c => new
                    {
                        Pgflstamp = c.String(nullable: false, maxLength: 80),
                        Pgfstamp = c.String(maxLength: 80),
                        Fccstamp = c.String(maxLength: 80),
                        Nrdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valorpreg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valorreg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Status = c.Boolean(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Descricao = c.String(maxLength: 80),
                        Numinterno = c.String(maxLength: 80),
                        Origem = c.String(maxLength: 80),
                        Mvalorpreg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mvalorreg = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Pgflstamp)
                .ForeignKey("dbo.Pgf", t => t.Pgfstamp)
                .Index(t => t.Pgfstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pgfl", "Pgfstamp", "dbo.Pgf");
            DropIndex("dbo.Pgfl", new[] { "Pgfstamp" });
            DropTable("dbo.Pgfl");
        }
    }
}
