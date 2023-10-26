namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsigahojeadd1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cc", "Pago");
            DropColumn("dbo.Cc", "Obsrcc");
            DropColumn("dbo.Cc", "Data_limite_pagamento");
            DropColumn("dbo.Cc", "Datapagamento");
            DropColumn("dbo.Fact", "Pago");
            DropColumn("dbo.Fact", "Obscc");
            DropColumn("dbo.Fact", "Data_limite_pagamento");
            DropColumn("dbo.Fact", "Datapagamento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fact", "Datapagamento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Fact", "Data_limite_pagamento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Fact", "Obscc", c => c.String(nullable: false));
            AddColumn("dbo.Fact", "Pago", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cc", "Datapagamento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cc", "Data_limite_pagamento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cc", "Obsrcc", c => c.String(nullable: false));
            AddColumn("dbo.Cc", "Pago", c => c.Boolean(nullable: false));
        }
    }
}
