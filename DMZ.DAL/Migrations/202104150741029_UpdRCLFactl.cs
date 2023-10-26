namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRCLFactl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Guias", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.RCL", "Especial", c => c.Boolean(nullable: false));
            AddColumn("dbo.Contas", "Especial", c => c.Boolean(nullable: false));
            AddColumn("dbo.TRcl", "Especial", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Usalocalreport", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Factl", "Descricao", c => c.String(nullable: false));
            AlterColumn("dbo.Dil", "Descricao", c => c.String(nullable: false));
            AlterColumn("dbo.Faccl", "Descricao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Faccl", "Descricao", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Dil", "Descricao", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Factl", "Descricao", c => c.String(nullable: false, maxLength: 600));
            DropColumn("dbo.Param", "Usalocalreport");
            DropColumn("dbo.TRcl", "Especial");
            DropColumn("dbo.Contas", "Especial");
            DropColumn("dbo.RCL", "Especial");
            DropColumn("dbo.Factl", "Guias");
        }
    }
}
