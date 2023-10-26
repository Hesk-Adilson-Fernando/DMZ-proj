namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAuxiliar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auxiliar", "Obs", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auxiliar", "Obs");
        }
    }
}
