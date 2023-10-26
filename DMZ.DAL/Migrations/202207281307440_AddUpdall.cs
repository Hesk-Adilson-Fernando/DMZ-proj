namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdall : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Armazemstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mstk", "Armazemstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Armazemstamp2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Armazemstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "Armazemstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ccu_Arm", "Armazemstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Armazemstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Armazemstamp");
            DropColumn("dbo.Ccu_Arm", "Armazemstamp");
            DropColumn("dbo.Faccl", "Armazemstamp");
            DropColumn("dbo.Dil", "Armazemstamp");
            DropColumn("dbo.Dil", "Armazemstamp2");
            DropColumn("dbo.Mstk", "Armazemstamp");
            DropColumn("dbo.Factl", "Armazemstamp");
        }
    }
}
