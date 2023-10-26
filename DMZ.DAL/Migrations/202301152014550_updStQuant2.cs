namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updStQuant2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StQuant", "Ivainc", c => c.Boolean(nullable: false));
            AddColumn("dbo.StQuant", "Imagem", c => c.Binary());
            AddColumn("dbo.StQuant", "CCusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.StQuant", "CodCCu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.StQuant", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StQuant", "Ccustamp");
            DropColumn("dbo.StQuant", "CodCCu");
            DropColumn("dbo.StQuant", "CCusto");
            DropColumn("dbo.StQuant", "Imagem");
            DropColumn("dbo.StQuant", "Ivainc");
        }
    }
}
