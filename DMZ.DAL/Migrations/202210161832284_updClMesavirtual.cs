namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updClMesavirtual : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Unimesa",
                c => new
                    {
                        Unimesastamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Unimesastamp);
            
            CreateTable(
                "dbo.Unimesal",
                c => new
                    {
                        Unimesalstamp = c.String(nullable: false, maxLength: 80),
                        Unimesastamp = c.String(nullable: false, maxLength: 80),
                        Messastamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Total = c.Decimal(nullable: false, precision: 16, scale: 2),
                    })
                .PrimaryKey(t => t.Unimesalstamp)
                .ForeignKey("dbo.Unimesa", t => t.Unimesastamp, cascadeDelete: true)
                .Index(t => t.Unimesastamp);
            
            AddColumn("dbo.Cl", "Mesavirtual", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Unimesal", "Unimesastamp", "dbo.Unimesa");
            DropIndex("dbo.Unimesal", new[] { "Unimesastamp" });
            DropColumn("dbo.Cl", "Mesavirtual");
            DropTable("dbo.Unimesal");
            DropTable("dbo.Unimesa");
        }
    }
}
