namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updstt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "TipoCombustivel", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.St", "Combustivel", c => c.Boolean(nullable: false));
            AlterColumn("dbo.St", "Trailer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.St", "Trailer", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.St", "Combustivel", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.St", "TipoCombustivel");
        }
    }
}
