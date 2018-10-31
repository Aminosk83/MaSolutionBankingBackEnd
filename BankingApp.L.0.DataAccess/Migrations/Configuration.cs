namespace BankingApp.L._0.DataAccess.Migrations
{
    using BankingApp.L._0.DataAccess.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BankingApp.L._0.DataAccess.Infrastructure.BankingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BankingApp.L._0.DataAccess.Infrastructure.BankingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Comptes.AddOrUpdate(new Compte { Numero = "c1000", Propiertaire = "Amine", Solde = 1000M });
            context.Comptes.AddOrUpdate(new Compte { Numero = "c2000", Propiertaire = "Chtoui", Solde = 1500M });
            context.Comptes.AddOrUpdate(new Compte { Numero = "c3000", Propiertaire = "Med", Solde = 1300M });

        }
    }
}
