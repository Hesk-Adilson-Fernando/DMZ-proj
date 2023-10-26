namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter20223 : DbMigration
    {
        public override void Up()
        {
           // DropColumn("dbo.Fnc", "Contasstamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fnc", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
