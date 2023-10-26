namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterUsrAcessos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modulosfrmdoc", "Oristamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usracessos", "Oristamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usracessos", "Oristamp");
            DropColumn("dbo.Modulosfrmdoc", "Oristamp");
        }
    }
}
