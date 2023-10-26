namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updEmp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empresa", "logo", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empresa", "logo", c => c.Byte(nullable: false));
        }
    }
}
