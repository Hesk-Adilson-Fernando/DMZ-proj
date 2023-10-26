namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClmorada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClMorada",
                c => new
                    {
                        ClMoradastamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Zona = c.String(nullable: false, maxLength: 80),
                        Morada = c.String(nullable: false, maxLength: 80),
                        Pessoa = c.String(nullable: false, maxLength: 80),
                        Telefone = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.ClMoradastamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            AddColumn("dbo.Fact", "Localentrega", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Pais", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Cell", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Mail", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Estado", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Matricula", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Pcontacto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Factl", "Morada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Factl", "Telefone", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Factl", "Entrega", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factl", "Dataentrega", c => c.DateTime(nullable: false));
            AddColumn("dbo.Factl", "Pcontacto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Factl", "Email", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Factl", "Pais", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Variasmoradas", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Lancaend", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Mostraendereco", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Usadoprod", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Dimensao", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Devolc", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Usaserie", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Obterpeso", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Peso", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Volume", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Usalote", c => c.Boolean(nullable: false));
            AddColumn("dbo.Starm", "Endereco", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fact", "No", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fact", "Mesa", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.RCL", "No", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Cl", "No", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fnc", "No", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Cl", "No", unique: true, name: "IX_X_Cl");
            CreateIndex("dbo.Fnc", "No", unique: true, name: "IX_X_Fnc");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClMorada", "Clstamp", "dbo.Cl");
            DropIndex("dbo.Fnc", "IX_X_Fnc");
            DropIndex("dbo.ClMorada", new[] { "Clstamp" });
            DropIndex("dbo.Cl", "IX_X_Cl");
            AlterColumn("dbo.Fnc", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Cl", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.RCL", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Mesa", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Starm", "Endereco");
            DropColumn("dbo.St", "Usalote");
            DropColumn("dbo.St", "Volume");
            DropColumn("dbo.St", "Peso");
            DropColumn("dbo.St", "Obterpeso");
            DropColumn("dbo.St", "Usaserie");
            DropColumn("dbo.St", "Devolc");
            DropColumn("dbo.St", "Dimensao");
            DropColumn("dbo.St", "Usadoprod");
            DropColumn("dbo.Param", "Mostraendereco");
            DropColumn("dbo.Tdoc", "Lancaend");
            DropColumn("dbo.Cl", "Variasmoradas");
            DropColumn("dbo.Factl", "Pais");
            DropColumn("dbo.Factl", "Email");
            DropColumn("dbo.Factl", "Pcontacto");
            DropColumn("dbo.Factl", "Dataentrega");
            DropColumn("dbo.Factl", "Entrega");
            DropColumn("dbo.Factl", "Telefone");
            DropColumn("dbo.Factl", "Morada");
            DropColumn("dbo.Fact", "Pcontacto");
            DropColumn("dbo.Fact", "Matricula");
            DropColumn("dbo.Fact", "Estado");
            DropColumn("dbo.Fact", "Mail");
            DropColumn("dbo.Fact", "Cell");
            DropColumn("dbo.Fact", "Pais");
            DropColumn("dbo.Fact", "Localentrega");
            DropTable("dbo.ClMorada");
        }
    }
}
