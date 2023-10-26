namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addprc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prc",
                c => new
                    {
                        Prcstamp = c.String(nullable: false, maxLength: 80),
                        Processstamp = c.String(nullable: false, maxLength: 80),
                        nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mes = c.String(nullable: false, maxLength: 80),
                        ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        data = c.DateTime(nullable: false),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        codcat = c.Decimal(nullable: false, precision: 9, scale: 0),
                        cat = c.String(nullable: false, maxLength: 80),
                        coddesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        codfun = c.Decimal(nullable: false, precision: 9, scale: 0),
                        codesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        escalao = c.Decimal(nullable: false, precision: 9, scale: 0),
                        indice = c.String(nullable: false, maxLength: 80),
                        codsec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        codcl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        classe = c.String(nullable: false, maxLength: 80),
                        quota = c.Boolean(nullable: false),
                        sind = c.String(nullable: false, maxLength: 80),
                        nsind = c.Decimal(nullable: false, precision: 9, scale: 0),
                        codsit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        situacao = c.String(nullable: false, maxLength: 80),
                        BaseCateg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        totsub = c.Decimal(nullable: false, precision: 9, scale: 0),
                        totabonus = c.Decimal(nullable: false, precision: 9, scale: 0),
                        totdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        liquido = c.Decimal(nullable: false, precision: 9, scale: 0),
                        obs = c.String(nullable: false, maxLength: 80),
                        fechado = c.Boolean(nullable: false),
                        valoremp = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ValEmp = c.Decimal(nullable: false, precision: 9, scale: 0),
                        SegSocEmp = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Prcstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Prc");
        }
    }
}
