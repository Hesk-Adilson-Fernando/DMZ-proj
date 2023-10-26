﻿namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updProcesPeriodo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proces", "Periodo", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proces", "Periodo");
        }
    }
}
