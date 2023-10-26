namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstarm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Starm",
                c => new
                    {
                        Starmstamp = c.String(nullable: false, maxLength: 80),
                        Codarm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Stock = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ref = c.String(maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Starmstamp);
            
            AddColumn("dbo.Armazem", "Sector", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Armazem", "Sector");
            DropTable("dbo.Starm");
        }
    }
}
