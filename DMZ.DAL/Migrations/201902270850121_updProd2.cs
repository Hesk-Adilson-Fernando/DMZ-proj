namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updProd2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produto", "Imagem", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produto", "Imagem", c => c.Byte(nullable: false));
        }
    }
}
