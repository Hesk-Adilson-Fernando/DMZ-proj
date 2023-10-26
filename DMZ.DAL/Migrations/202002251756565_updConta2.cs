namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updConta2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contas", "Numero", c => c.Decimal(nullable: false, precision: 16, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contas", "Numero", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
