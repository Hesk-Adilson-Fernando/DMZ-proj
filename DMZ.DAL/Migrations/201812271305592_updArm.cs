namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updArm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Armazem", "Obs", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Armazem", "Obs");
        }
    }
}
