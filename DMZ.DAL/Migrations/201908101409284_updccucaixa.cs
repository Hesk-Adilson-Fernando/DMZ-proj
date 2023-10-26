namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updccucaixa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ccu_Caixa", "Poscaixa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ccu_Caixa", "Posbanco", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ccu_Caixa", "Posbanco");
            DropColumn("dbo.Ccu_Caixa", "Poscaixa");
        }
    }
}
