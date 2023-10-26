namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updempLogofundo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresa", "ImagemFundo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresa", "ImagemFundo");
        }
    }
}
