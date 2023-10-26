﻿namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usrcaixasrstamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caixa", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Caixa", "Usrstamp");
        }
    }
}
