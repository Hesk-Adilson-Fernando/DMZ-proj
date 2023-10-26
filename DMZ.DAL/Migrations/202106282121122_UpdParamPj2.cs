namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdParamPj2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Naomostrasequencia", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Ponaorepete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Ponaorepete");
            DropColumn("dbo.Param", "Naomostrasequencia");
        }
    }
}
