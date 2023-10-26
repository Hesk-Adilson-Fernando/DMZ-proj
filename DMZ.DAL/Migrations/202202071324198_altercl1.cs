namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altercl1 : DbMigration
    {
        public override void Up()
        {
           // DropColumn("dbo.Cl", "Contasstamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cl", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
