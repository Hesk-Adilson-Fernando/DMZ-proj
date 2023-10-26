namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRltMostracfe2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rlt", "Mostracfe", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rlt", "Mostracfe", c => c.Int(nullable: false));
        }
    }
}
