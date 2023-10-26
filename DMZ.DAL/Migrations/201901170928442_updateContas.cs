namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateContas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contas", "Descricao", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contas", "Descricao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
