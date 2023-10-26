namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updvend2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vend", "Celular", c => c.String(maxLength: 80));
            DropColumn("dbo.Vend", "Celucar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vend", "Celucar", c => c.String(maxLength: 80));
            DropColumn("dbo.Vend", "Celular");
        }
    }
}
