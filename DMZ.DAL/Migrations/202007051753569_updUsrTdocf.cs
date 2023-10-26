namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updUsrTdocf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdocf", "Usaprovacao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "AprovaPagamento", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "ValorMaxPagamento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "ValorMaxPagamento");
            DropColumn("dbo.Usr", "AprovaPagamento");
            DropColumn("dbo.Tdocf", "Usaprovacao");
        }
    }
}
