namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NaoverificaNuit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "MatriculaAluno", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dclasse", "Motivo", c => c.String(nullable: false));
            AddColumn("dbo.MatriculaAluno", "Numdoc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.MatriculaAluno", "Inscricao", c => c.Boolean(nullable: false));
            AddColumn("dbo.MatriculaAluno", "Matricula", c => c.Boolean(nullable: false));
            AddColumn("dbo.MatriculaAluno", "Nomedoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Removematricula", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "NaoverificaNuit", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "NaoverificaNuit");
            DropColumn("dbo.Param", "Removematricula");
            DropColumn("dbo.MatriculaAluno", "Nomedoc");
            DropColumn("dbo.MatriculaAluno", "Matricula");
            DropColumn("dbo.MatriculaAluno", "Inscricao");
            DropColumn("dbo.MatriculaAluno", "Numdoc");
            DropColumn("dbo.Dclasse", "Motivo");
            DropColumn("dbo.Fact", "MatriculaAluno");
        }
    }
}
