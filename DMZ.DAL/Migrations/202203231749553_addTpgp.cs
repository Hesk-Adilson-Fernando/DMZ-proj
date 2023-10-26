namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTpgp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tpgp",
                c => new
                    {
                        Tpgpstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Descmovcc = c.String(nullable: false, maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codmovtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovtz = c.String(nullable: false, maxLength: 80),
                        Contastesoura = c.String(nullable: false, maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Titulo = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Entida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Activo = c.Boolean(nullable: false),
                        Defa = c.Boolean(nullable: false),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(nullable: false, maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(nullable: false, maxLength: 80),
                        Rcladiant = c.Boolean(nullable: false),
                        Nomfile = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Tpgpstamp);
            
            AddColumn("dbo.Percl", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pecc", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Percll", "Rcladiant", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Percll", "Rcladiant");
            DropColumn("dbo.Pecc", "Rcladiant");
            DropColumn("dbo.Percl", "Rcladiant");
            DropTable("dbo.Tpgp");
        }
    }
}
