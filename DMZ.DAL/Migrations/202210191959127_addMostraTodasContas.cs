namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMostraTodasContas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "MostraTodasContas", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "MostraTodasContas");
            DropColumn("dbo.Contas", "Ccustamp");
        }
    }
}
