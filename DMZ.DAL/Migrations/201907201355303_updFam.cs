namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Familia", "Imagem", c => c.Binary());
            AlterColumn("dbo.SubFam", "Imagem", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubFam", "Imagem", c => c.Byte(nullable: false));
            AlterColumn("dbo.Familia", "Imagem", c => c.Byte(nullable: false));
        }
    }
}
