namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updParam_intervalo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Intervalo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Teste", "descricao2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Teste", "Descricao2", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teste", "Descricao2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Teste", "descricao2", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Param", "Intervalo");
        }
    }
}
