namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBancoArm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armazem",
                c => new
                    {
                        Armazemstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Padrao = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Armazemstamp);
            
            CreateTable(
                "dbo.Banco",
                c => new
                    {
                        Bancostamp = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(maxLength: 80),
                        Nome = c.String(maxLength: 80),
                        Cx = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Bancostamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Banco");
            DropTable("dbo.Armazem");
        }
    }
}
