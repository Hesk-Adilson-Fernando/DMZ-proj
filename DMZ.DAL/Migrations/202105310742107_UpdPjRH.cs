namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPjRH : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PjRh", "Pjstamp", "dbo.Pj");
            DropIndex("dbo.PjRh", new[] { "Pjstamp" });
            CreateTable(
                "dbo.TdocPj",
                c => new
                    {
                        Tdocpjstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Defa = c.Boolean(nullable: false),
                        Compra = c.Boolean(nullable: false),
                        Venda = c.Boolean(nullable: false),
                        Di = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Tdocpjstamp)
                .Index(t => t.Sigla, unique: true);
            
            AddColumn("dbo.Param", "HorasdeTrabalho", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "NDiasmes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "DescricaoFalta", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "CodigoDescricaoFalta", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "ExcluiProcess", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "ExcluiEstatistica", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "Horas", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pehextra", "TipoHoraExtra", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pehextra", "CodigoTipoHoraExtra", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "Numdoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Nomedoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Tipo", c => c.String(nullable: false));
            AddColumn("dbo.Pjesc", "Sequenc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Ref", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Quant", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Unidade", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Armazem", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Preco", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Mpreco", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Tabiva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Txiva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Valival", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Perdesc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Descontol", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Subtotall", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Oristampl", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Oristamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Descarm", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Nome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Totall", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Ivainc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pjesc", "Servico", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pjesc", "SubContrada", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pjesc", "Ordem", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Proces", "CodigoMes", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Sub", "SofreDescontoFalta", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Pjesc", "Descricao", c => c.String(nullable: false));
            AlterColumn("dbo.Pjesc", "Adenda", c => c.Boolean(nullable: false));
            DropColumn("dbo.Pehextra", "Inicio");
            DropColumn("dbo.Pehextra", "Fim");
            DropColumn("dbo.Pehextra", "Document");
            DropColumn("dbo.Pj", "DatIniReal");
            DropColumn("dbo.Pj", "DiasReais");
            DropColumn("dbo.Pjesc", "NoEscodido");
            DropColumn("dbo.Pjesc", "DatIniReal");
            DropColumn("dbo.Pjesc", "DatTerminoReal");
            DropColumn("dbo.Pjesc", "DiasReais");
            DropColumn("dbo.Pjesc", "Noedita");
            DropColumn("dbo.Pjesc", "Tcusto");
            DropColumn("dbo.Pjesc", "Orc");
            DropColumn("dbo.Pjesc", "Adendaper");
            DropColumn("dbo.Pjesc", "Totorc");
            DropColumn("dbo.Pjesc", "Totft");
            DropColumn("dbo.Pjesc", "Totftper");
            DropColumn("dbo.Pjesc", "Totrec");
            DropColumn("dbo.Pjesc", "Totrecper");
            DropColumn("dbo.Pjesc", "Totprec");
            DropColumn("dbo.Pjesc", "Totprecper");
            DropColumn("dbo.Pjesc", "Totpft");
            DropColumn("dbo.Pjesc", "Totpftper");
            DropColumn("dbo.Pjesc", "Lucro");
            DropColumn("dbo.Pjesc", "Lucroper");
            DropColumn("dbo.Pjesc", "RH");
            DropColumn("dbo.Pjesc", "Pretermino");
            DropTable("dbo.PjRh");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PjRh",
                c => new
                    {
                        PjRhstamp = c.String(nullable: false, maxLength: 80),
                        Referencia = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Funcao = c.String(nullable: false, maxLength: 80),
                        Custo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dataini = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                        Dias = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ValBasico = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.PjRhstamp);
            
            AddColumn("dbo.Pjesc", "Pretermino", c => c.DateTime());
            AddColumn("dbo.Pjesc", "RH", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Lucroper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Lucro", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totpftper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totpft", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totprecper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totprec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totrecper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totrec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totftper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totft", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Totorc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Adendaper", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Orc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Tcusto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "Noedita", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "DiasReais", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pjesc", "DatTerminoReal", c => c.DateTime());
            AddColumn("dbo.Pjesc", "DatIniReal", c => c.DateTime());
            AddColumn("dbo.Pjesc", "NoEscodido", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "DiasReais", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pj", "DatIniReal", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pehextra", "Document", c => c.Binary());
            AddColumn("dbo.Pehextra", "Fim", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pehextra", "Inicio", c => c.DateTime(nullable: false));
            DropIndex("dbo.TdocPj", new[] { "Sigla" });
            AlterColumn("dbo.Pjesc", "Adenda", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pjesc", "Descricao", c => c.String(nullable: false, maxLength: 600));
            DropColumn("dbo.Sub", "SofreDescontoFalta");
            DropColumn("dbo.Proces", "CodigoMes");
            DropColumn("dbo.Pjesc", "Ordem");
            DropColumn("dbo.Pjesc", "SubContrada");
            DropColumn("dbo.Pjesc", "Servico");
            DropColumn("dbo.Pjesc", "Ivainc");
            DropColumn("dbo.Pjesc", "Totall");
            DropColumn("dbo.Pjesc", "Nome");
            DropColumn("dbo.Pjesc", "Descarm");
            DropColumn("dbo.Pjesc", "Oristamp");
            DropColumn("dbo.Pjesc", "Oristampl");
            DropColumn("dbo.Pjesc", "Subtotall");
            DropColumn("dbo.Pjesc", "Descontol");
            DropColumn("dbo.Pjesc", "Perdesc");
            DropColumn("dbo.Pjesc", "Valival");
            DropColumn("dbo.Pjesc", "Txiva");
            DropColumn("dbo.Pjesc", "Tabiva");
            DropColumn("dbo.Pjesc", "Mpreco");
            DropColumn("dbo.Pjesc", "Preco");
            DropColumn("dbo.Pjesc", "Armazem");
            DropColumn("dbo.Pjesc", "Unidade");
            DropColumn("dbo.Pjesc", "Quant");
            DropColumn("dbo.Pjesc", "Ref");
            DropColumn("dbo.Pjesc", "Sequenc");
            DropColumn("dbo.Pjesc", "Tipo");
            DropColumn("dbo.Pj", "Nomedoc");
            DropColumn("dbo.Pj", "Numdoc");
            DropColumn("dbo.Pehextra", "CodigoTipoHoraExtra");
            DropColumn("dbo.Pehextra", "TipoHoraExtra");
            DropColumn("dbo.Pefalta", "Horas");
            DropColumn("dbo.Pefalta", "ExcluiEstatistica");
            DropColumn("dbo.Pefalta", "ExcluiProcess");
            DropColumn("dbo.Pefalta", "CodigoDescricaoFalta");
            DropColumn("dbo.Pefalta", "DescricaoFalta");
            DropColumn("dbo.Param", "NDiasmes");
            DropColumn("dbo.Param", "HorasdeTrabalho");
            DropTable("dbo.TdocPj");
            CreateIndex("dbo.PjRh", "Pjstamp");
            AddForeignKey("dbo.PjRh", "Pjstamp", "dbo.Pj", "Pjstamp", cascadeDelete: true);
        }
    }
}
