namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatepjClassificador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pjesc", "Classificador", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Pjesc", "Duracao", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            DropColumn("dbo.Pjesc", "Tipo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pjesc", "Tipo", c => c.String(nullable: false));
            AlterColumn("dbo.Pjesc", "Duracao", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            DropColumn("dbo.Pjesc", "Classificador");
        }
    }
}
