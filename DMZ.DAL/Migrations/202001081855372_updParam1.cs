namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updParam1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IV", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Ivcodentr", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "Ivdescentr", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Ivcodsai", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "Ivdescsai", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.IV", "Totaliva");
            DropColumn("dbo.IV", "Impresso");
            DropColumn("dbo.IV", "Usrimpress");
            DropColumn("dbo.IV", "Impressodh");
            DropColumn("dbo.IV", "Lancado");
            DropColumn("dbo.IV", "Usrlanc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IV", "Usrlanc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.IV", "Lancado", c => c.Boolean(nullable: false));
            AddColumn("dbo.IV", "Impressodh", c => c.DateTime(nullable: false));
            AddColumn("dbo.IV", "Usrimpress", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.IV", "Impresso", c => c.Boolean(nullable: false));
            AddColumn("dbo.IV", "Totaliva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Param", "Ivdescsai");
            DropColumn("dbo.Param", "Ivcodsai");
            DropColumn("dbo.Param", "Ivdescentr");
            DropColumn("dbo.Param", "Ivcodentr");
            DropColumn("dbo.IV", "Descricao");
        }
    }
}
