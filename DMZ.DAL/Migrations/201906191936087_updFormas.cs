namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFormas : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Formasp", "Distamp");
            AddForeignKey("dbo.Formasp", "Distamp", "dbo.Di", "Distamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Formasp", "Distamp", "dbo.Di");
            DropIndex("dbo.Formasp", new[] { "Distamp" });
        }
    }
}
