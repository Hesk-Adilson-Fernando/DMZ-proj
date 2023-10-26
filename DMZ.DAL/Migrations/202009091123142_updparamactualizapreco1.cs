namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updparamactualizapreco1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Param", "Actualizapreco", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Param", "Actualizapreco", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
