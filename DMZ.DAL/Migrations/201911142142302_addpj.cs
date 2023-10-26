namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpj : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pe",
                c => new
                    {
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Morada = c.String(nullable: false, maxLength: 80),
                        Locali = c.String(nullable: false, maxLength: 80),
                        Natural = c.String(nullable: false, maxLength: 80),
                        Nacional = c.String(nullable: false, maxLength: 80),
                        Contacto = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                        Datanasc = c.DateTime(nullable: false),
                        Ecivil = c.String(nullable: false, maxLength: 80),
                        Pai = c.String(nullable: false, maxLength: 80),
                        Mae = c.String(nullable: false, maxLength: 80),
                        Sexo = c.String(nullable: false, maxLength: 80),
                        Codstatus = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descstatus = c.String(nullable: false, maxLength: 80),
                        Codsit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Situacao = c.String(nullable: false, maxLength: 80),
                        Nuit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codcat = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desccat = c.String(nullable: false, maxLength: 80),
                        Codprof = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descprof = c.String(nullable: false, maxLength: 80),
                        Dataadm = c.DateTime(nullable: false),
                        Tipodocum = c.String(nullable: false, maxLength: 80),
                        Numdocum = c.String(nullable: false, maxLength: 80),
                        Locemiss = c.String(nullable: false, maxLength: 80),
                        Dataemiss = c.DateTime(nullable: false),
                        Documvalid = c.DateTime(nullable: false),
                        Codhabliter = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Habliter = c.String(nullable: false, maxLength: 80),
                        Codbanco = c.String(nullable: false, maxLength: 80),
                        Banco = c.String(nullable: false, maxLength: 80),
                        Numconta = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nib = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Trf = c.Boolean(nullable: false),
                        Ntabelado = c.Boolean(nullable: false),
                        Ponto = c.Boolean(nullable: false),
                        Pontonome = c.String(nullable: false, maxLength: 80),
                        Valbase = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codirps = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descirps = c.String(nullable: false, maxLength: 80),
                        Nrdep = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codsgs = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descsgs = c.String(nullable: false, maxLength: 80),
                        Numsgs = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codtiposgs = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desctiposgs = c.String(nullable: false, maxLength: 80),
                        Numsindic = c.String(nullable: false, maxLength: 80),
                        Codsindic = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descsindic = c.String(nullable: false, maxLength: 80),
                        Persindic = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codlevel1 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desclevel1 = c.String(nullable: false, maxLength: 80),
                        Codlevel2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desclevel2 = c.String(nullable: false, maxLength: 80),
                        Codlevel3 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desclevel3 = c.String(nullable: false, maxLength: 80),
                        Codlevel4 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desclevel4 = c.String(nullable: false, maxLength: 80),
                        Codccusto = c.String(nullable: false, maxLength: 80),
                        Desccusto = c.String(nullable: false, maxLength: 80),
                        Foto = c.Binary(),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pecontra",
                c => new
                    {
                        Pecontrastamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Pecontrastamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pedesc",
                c => new
                    {
                        Pedescstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Pedescstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pefalta",
                c => new
                    {
                        Pefaltastamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Origem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fjust = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Finjust = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Processado = c.Boolean(nullable: false),
                        Desctfalta = c.String(nullable: false, maxLength: 80),
                        Codtfalta = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mes = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pefaltastamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Peferias",
                c => new
                    {
                        Peferiasstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estado = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Peferiasstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pehextra",
                c => new
                    {
                        Pehextrastamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Horas = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Processado = c.Boolean(nullable: false),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mes = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pehextrastamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pesub",
                c => new
                    {
                        Pesubstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Pesubstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pj",
                c => new
                    {
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Datini = c.DateTime(nullable: false),
                        Datfim = c.DateTime(nullable: false),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Estado = c.Boolean(nullable: false),
                        Datfecho = c.DateTime(nullable: false),
                        Tcusto = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Orc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Adenda = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Adendaper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totorc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totft = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totftper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totrec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totrecper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totprec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totprecper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totpft = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totpftper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Lucro = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Lucroper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Pcontact = c.String(nullable: false, maxLength: 80),
                        Tcontact = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Codccu = c.String(nullable: false, maxLength: 80),
                        Ccudesc = c.String(nullable: false, maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Pjstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pesub", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pehextra", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Peferias", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pefalta", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pedesc", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pecontra", "Pestamp", "dbo.Pe");
            DropIndex("dbo.Pesub", new[] { "Pestamp" });
            DropIndex("dbo.Pehextra", new[] { "Pestamp" });
            DropIndex("dbo.Peferias", new[] { "Pestamp" });
            DropIndex("dbo.Pefalta", new[] { "Pestamp" });
            DropIndex("dbo.Pedesc", new[] { "Pestamp" });
            DropIndex("dbo.Pecontra", new[] { "Pestamp" });
            DropTable("dbo.Pj");
            DropTable("dbo.Pesub");
            DropTable("dbo.Pehextra");
            DropTable("dbo.Peferias");
            DropTable("dbo.Pefalta");
            DropTable("dbo.Pedesc");
            DropTable("dbo.Pecontra");
            DropTable("dbo.Pe");
        }
    }
}
