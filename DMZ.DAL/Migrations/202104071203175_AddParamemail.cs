namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddParamemail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paramemail",
                c => new
                    {
                        Paramemailstamp = c.String(nullable: false, maxLength: 80),
                        Paramstamp = c.String(nullable: false, maxLength: 80),
                        Login = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Stockmin = c.Boolean(nullable: false),
                        Aprovacompra = c.Boolean(nullable: false),
                        Param1 = c.Boolean(nullable: false),
                        Param2 = c.Boolean(nullable: false),
                        Param3 = c.Boolean(nullable: false),
                        Param4 = c.Boolean(nullable: false),
                        Param5 = c.Boolean(nullable: false),
                        Param6 = c.Boolean(nullable: false),
                        Param7 = c.Boolean(nullable: false),
                        Param8 = c.Boolean(nullable: false),
                        Param9 = c.Boolean(nullable: false),
                        Param10 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Paramemailstamp)
                .ForeignKey("dbo.Param", t => t.Paramstamp, cascadeDelete: true)
                .Index(t => t.Paramstamp);
            
            AddColumn("dbo.Param", "Smtpserver", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Smtpport", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "Outgoingemail", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Outgoingpassword", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Subjemail", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Emailtext", c => c.String(nullable: false, maxLength: 650));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paramemail", "Paramstamp", "dbo.Param");
            DropIndex("dbo.Paramemail", new[] { "Paramstamp" });
            DropColumn("dbo.Param", "Emailtext");
            DropColumn("dbo.Param", "Subjemail");
            DropColumn("dbo.Param", "Outgoingpassword");
            DropColumn("dbo.Param", "Outgoingemail");
            DropColumn("dbo.Param", "Smtpport");
            DropColumn("dbo.Param", "Smtpserver");
            DropTable("dbo.Paramemail");
        }
    }
}
