namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFncBom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FncBomb",
                c => new
                    {
                        Fncbombstamp = c.String(nullable: false, maxLength: 80),
                        Fncstamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Fncbombstamp)
                .ForeignKey("dbo.Fnc", t => t.Fncstamp, cascadeDelete: true)
                .Index(t => t.Fncstamp);
            
            AddColumn("dbo.Di", "Bomba", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FncBomb", "Fncstamp", "dbo.Fnc");
            DropIndex("dbo.FncBomb", new[] { "Fncstamp" });
            DropColumn("dbo.Di", "Bomba");
            DropTable("dbo.FncBomb");
        }
    }
}
