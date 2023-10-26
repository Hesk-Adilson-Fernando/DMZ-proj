namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddocstampall : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Tdocstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Tdistamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Tdocfstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgf", "Tpgfstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Percl", "TPerclstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "TRclstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Tdocpjstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pj", "Tdocpjstamp");
            DropColumn("dbo.RCL", "TRclstamp");
            DropColumn("dbo.Percl", "TPerclstamp");
            DropColumn("dbo.Pgf", "Tpgfstamp");
            DropColumn("dbo.Facc", "Tdocfstamp");
            DropColumn("dbo.Di", "Tdistamp");
            DropColumn("dbo.Fact", "Tdocstamp");
        }
    }
}
