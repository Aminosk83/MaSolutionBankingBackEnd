namespace BankingApp.L._0.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreationInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        Numero = c.String(nullable: false, maxLength: 128),
                        Propiertaire = c.String(),
                        Solde = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Numero);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comptes");
        }
    }
}
