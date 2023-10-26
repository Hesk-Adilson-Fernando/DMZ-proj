namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Upddi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Di", "PjNome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Localmanut", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Fechomanut", c => c.Boolean(nullable: false));
            AddColumn("dbo.Di", "Datafecho", c => c.DateTime(nullable: false));
            DropColumn("dbo.Di", "Dtpartida");
            DropColumn("dbo.Di", "Dtchegada");
            DropColumn("dbo.Di", "Localmanutencao");
            DropColumn("dbo.Di", "Tmanutencao");
            DropColumn("dbo.Di", "Dtentrada");
            DropColumn("dbo.Di", "Dtsaida");
            DropColumn("dbo.Di", "Tipocombustivel");
            DropColumn("dbo.Di", "Funcao");
            DropColumn("dbo.Di", "Dias");
            DropColumn("dbo.Di", "Salliquido");
            DropColumn("dbo.Di", "Descricao");
            DropColumn("dbo.Di", "ValorMulta");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Di", "ValorMulta", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Salliquido", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Dias", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Funcao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Tipocombustivel", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Dtsaida", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Dtentrada", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Tmanutencao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Localmanutencao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Dtchegada", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Dtpartida", c => c.DateTime(nullable: false));
            DropColumn("dbo.Di", "Datafecho");
            DropColumn("dbo.Di", "Fechomanut");
            DropColumn("dbo.Di", "Localmanut");
            DropColumn("dbo.Di", "PjNome");
        }
    }
}
