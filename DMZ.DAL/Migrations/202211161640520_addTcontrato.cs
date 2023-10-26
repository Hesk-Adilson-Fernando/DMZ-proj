namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTcontrato : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TContrato",
                c => new
                    {
                        TContratostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.TContratostamp);
            
            AddColumn("dbo.Pecontra", "Tipo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pecontra", "Tipo");
            DropTable("dbo.TContrato");
        }
    }
}
