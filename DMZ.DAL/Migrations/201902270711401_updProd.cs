namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updProd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Imagem", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Imagem");
        }
    }
}
