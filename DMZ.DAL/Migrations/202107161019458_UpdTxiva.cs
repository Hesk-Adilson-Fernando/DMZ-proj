namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTxiva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "PoObrigatorio", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "PjFechoautomatico", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Factl", "Txiva", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AlterColumn("dbo.Dil", "Txiva", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AlterColumn("dbo.Faccl", "Txiva", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AlterColumn("dbo.St", "Txiva", c => c.Decimal(nullable: false, precision: 5, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.St", "Txiva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Faccl", "Txiva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Dil", "Txiva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Factl", "Txiva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Param", "PjFechoautomatico");
            DropColumn("dbo.Param", "PoObrigatorio");
        }
    }
}
