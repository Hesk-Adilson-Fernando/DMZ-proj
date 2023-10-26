namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updmanyT : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Factl", "Descricao", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Dil", "Descricao", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Faccl", "Descricao", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.St", "Descricao", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.St", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Faccl", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Dil", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Factl", "Descricao", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
