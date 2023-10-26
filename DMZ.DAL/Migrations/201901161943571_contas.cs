namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        Contasstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codtipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipo = c.String(maxLength: 80),
                        Moeda = c.String(maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(maxLength: 80),
                        Banco = c.String(maxLength: 80),
                        Morada = c.String(maxLength: 80),
                        Nib = c.String(maxLength: 80),
                        Nomecontacto = c.String(maxLength: 80),
                        Contacto = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                        Saldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Saldor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Noneg = c.Boolean(nullable: false),
                        Cxmn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Contasstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contas");
        }
    }
}
