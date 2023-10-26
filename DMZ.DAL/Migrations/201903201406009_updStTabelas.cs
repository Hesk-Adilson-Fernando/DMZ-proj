namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updStTabelas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProdConposto", "Produtostamp", "dbo.Produto");
            DropForeignKey("dbo.ProdPrecos", "Produtostamp", "dbo.Produto");
            DropIndex("dbo.ProdConposto", new[] { "Produtostamp" });
            DropIndex("dbo.ProdPrecos", new[] { "Produtostamp" });
            CreateTable(
                "dbo.StConposto",
                c => new
                    {
                        StConpostostamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(maxLength: 80),
                        descricao = c.String(maxLength: 80),
                        quantid = c.String(maxLength: 80),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.StConpostostamp)
                .ForeignKey("dbo.St", t => t.Ststamp)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.St",
                c => new
                    {
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Referenc = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Refornec = c.String(maxLength: 80),
                        Fornecedor = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                        Unidade = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Servico = c.Boolean(nullable: false),
                        Tabiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Txiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ivainc = c.Boolean(nullable: false),
                        Codfam = c.String(maxLength: 80),
                        Familia = c.String(maxLength: 80),
                        Codsubfam = c.String(maxLength: 80),
                        Subfamilia = c.String(maxLength: 80),
                        Codarm = c.String(maxLength: 80),
                        Armazem = c.String(maxLength: 80),
                        Codmarca = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Marca = c.String(maxLength: 80),
                        Codfab = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fabricante = c.String(maxLength: 80),
                        Negativo = c.Boolean(nullable: false),
                        Avisanegativo = c.Boolean(nullable: false),
                        Descontinuado = c.Boolean(nullable: false),
                        Combustivel = c.Boolean(nullable: false),
                        Ligaprojecto = c.Boolean(nullable: false),
                        Composto = c.Boolean(nullable: false),
                        Stock = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ultimopreco = c.Decimal(nullable: false, precision: 9, scale: 0),
                        precoponderado = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Imagem = c.Binary(),
                        Nmovstk = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ststamp);
            
            CreateTable(
                "dbo.StPrecos",
                c => new
                    {
                        StPrecostamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(maxLength: 80),
                        CCusto = c.String(maxLength: 80),
                        CodCCu = c.String(maxLength: 80),
                        Ivainc = c.Boolean(nullable: false),
                        padrao = c.Boolean(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.StPrecostamp)
                .ForeignKey("dbo.St", t => t.Ststamp)
                .Index(t => t.Ststamp);
            
            DropTable("dbo.ProdConposto");
            DropTable("dbo.Produto");
            DropTable("dbo.ProdPrecos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProdPrecos",
                c => new
                    {
                        ProdPrecostamp = c.String(nullable: false, maxLength: 80),
                        Produtostamp = c.String(maxLength: 80),
                        CCusto = c.String(maxLength: 80),
                        CodCCu = c.String(maxLength: 80),
                        Ivainc = c.Boolean(nullable: false),
                        padrao = c.Boolean(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.ProdPrecostamp);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Produtostamp = c.String(nullable: false, maxLength: 80),
                        Referenc = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Refornec = c.String(maxLength: 80),
                        Fornecedor = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                        Unidade = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Servico = c.Boolean(nullable: false),
                        Tabiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Txiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ivainc = c.Boolean(nullable: false),
                        Codfam = c.String(maxLength: 80),
                        Familia = c.String(maxLength: 80),
                        Codsubfam = c.String(maxLength: 80),
                        Subfamilia = c.String(maxLength: 80),
                        Codarm = c.String(maxLength: 80),
                        Armazem = c.String(maxLength: 80),
                        Codmarca = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Marca = c.String(maxLength: 80),
                        Codfab = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fabricante = c.String(maxLength: 80),
                        Negativo = c.Boolean(nullable: false),
                        Avisanegativo = c.Boolean(nullable: false),
                        Descontinuado = c.Boolean(nullable: false),
                        Combustivel = c.Boolean(nullable: false),
                        Ligaprojecto = c.Boolean(nullable: false),
                        Composto = c.Boolean(nullable: false),
                        Stock = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ultimopreco = c.Decimal(nullable: false, precision: 9, scale: 0),
                        precoponderado = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Imagem = c.Binary(),
                    })
                .PrimaryKey(t => t.Produtostamp);
            
            CreateTable(
                "dbo.ProdConposto",
                c => new
                    {
                        ProdConpostostamp = c.String(nullable: false, maxLength: 80),
                        Produtostamp = c.String(maxLength: 80),
                        descricao = c.String(maxLength: 80),
                        quantid = c.String(maxLength: 80),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.ProdConpostostamp);
            
            DropForeignKey("dbo.StPrecos", "Ststamp", "dbo.St");
            DropForeignKey("dbo.StConposto", "Ststamp", "dbo.St");
            DropIndex("dbo.StPrecos", new[] { "Ststamp" });
            DropIndex("dbo.StConposto", new[] { "Ststamp" });
            DropTable("dbo.StPrecos");
            DropTable("dbo.St");
            DropTable("dbo.StConposto");
            CreateIndex("dbo.ProdPrecos", "Produtostamp");
            CreateIndex("dbo.ProdConposto", "Produtostamp");
            AddForeignKey("dbo.ProdPrecos", "Produtostamp", "dbo.Produto", "Produtostamp");
            AddForeignKey("dbo.ProdConposto", "Produtostamp", "dbo.Produto", "Produtostamp");
        }
    }
}
