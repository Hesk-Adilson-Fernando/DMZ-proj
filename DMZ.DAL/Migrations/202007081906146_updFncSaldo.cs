namespace DMZ.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class updFncSaldo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cl", "Saldo", c => c.Decimal(nullable: false, precision: 16, scale: 2,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Default",
                        new AnnotationValues(oldValue: null, newValue: "0")
                    },
                }));
            AlterColumn("dbo.Fnc", "Saldo", c => c.Decimal(nullable: false, precision: 16, scale: 2,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Default",
                        new AnnotationValues(oldValue: null, newValue: "0")
                    },
                }));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fnc", "Saldo", c => c.Decimal(nullable: false, precision: 9, scale: 0,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Default",
                        new AnnotationValues(oldValue: "0", newValue: null)
                    },
                }));
            AlterColumn("dbo.Cl", "Saldo", c => c.Decimal(nullable: false, precision: 9, scale: 0,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Default",
                        new AnnotationValues(oldValue: "0", newValue: null)
                    },
                }));
        }
    }
}
