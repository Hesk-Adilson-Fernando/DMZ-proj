namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pefilhas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pehextra", "ValorProc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pehextra", "Horas", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pehextra", "Valor", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pehextra", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pehextra", "Horas", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pehextra", "ValorProc");
        }
    }
}
