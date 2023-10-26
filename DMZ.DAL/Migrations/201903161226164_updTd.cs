namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updTd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moedas",
                c => new
                    {
                        Moedasstamp = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Pais = c.String(maxLength: 80),
                        Princip = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Moedasstamp);
            
            AddColumn("dbo.Tdoc", "Tipodoc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdoc", "Tipodoc");
            DropTable("dbo.Moedas");
        }
    }
}
