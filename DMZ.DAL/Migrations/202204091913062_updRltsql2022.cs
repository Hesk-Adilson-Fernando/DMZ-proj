namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updRltsql2022 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rltsql", "Descricao", c => c.String(nullable: false, maxLength: 2500));
            AddColumn("dbo.Rltsql", "Geragrid", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rltsql", "Campo1", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rltsql", "Campo2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rltsql", "Campo3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tpgp", "Nomfile2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.ProcAnalFnc", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.ProcAnalFnc", "Tipo", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProcAnalFnc", "Tipo", c => c.String(nullable: false));
            AlterColumn("dbo.ProcAnalFnc", "Descricao", c => c.String(nullable: false));
            DropColumn("dbo.Tpgp", "Nomfile2");
            DropColumn("dbo.Rltsql", "Campo3");
            DropColumn("dbo.Rltsql", "Campo2");
            DropColumn("dbo.Rltsql", "Campo1");
            DropColumn("dbo.Rltsql", "Geragrid");
            DropColumn("dbo.Rltsql", "Descricao");
        }
    }
}
