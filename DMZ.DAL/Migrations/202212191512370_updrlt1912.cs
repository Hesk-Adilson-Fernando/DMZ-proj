namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updrlt1912 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "DescFiltroEntreDatas", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "FiltroEntreDatas", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "DescFiltroEntreAnos", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "FiltroEntreAnos", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "DescFiltroAno", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "FiltroAno", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "DescFiltroData", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "FiltroData", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Rlt", "FiltrosDatas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rlt", "FiltrosDatas", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Rlt", "FiltroData");
            DropColumn("dbo.Rlt", "DescFiltroData");
            DropColumn("dbo.Rlt", "FiltroAno");
            DropColumn("dbo.Rlt", "DescFiltroAno");
            DropColumn("dbo.Rlt", "FiltroEntreAnos");
            DropColumn("dbo.Rlt", "DescFiltroEntreAnos");
            DropColumn("dbo.Rlt", "FiltroEntreDatas");
            DropColumn("dbo.Rlt", "DescFiltroEntreDatas");
        }
    }
}
