namespace DMZ.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class updapparm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apparam", "ContaIrps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Apparam", "ContaIrpsdesc", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Apparam", "ContaIrpsdesc");
            DropColumn("dbo.Apparam", "ContaIrps");
        }
    }
}
