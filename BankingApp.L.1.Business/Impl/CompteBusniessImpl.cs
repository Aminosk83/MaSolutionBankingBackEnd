using BankingApp.L._0.DataAccess.Domain;
using BankingApp.L._0.DataAccess.Facade;
using BankingApp.L._0.DataAccess.Implementations;
using BankingApp.L._1.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L._1.Business.Impl
{
    public class CompteBusniessImpl : ICompteBusiness
    {
        private IComptesRepository repository = new ComptesRepositoryImpl_EF();
        public decimal? ConsulterSolde(string numero)
        {
            var rslt = repository.FindById(numero);
            return rslt?.Solde;
        }

        public IEnumerable<Compte> TousLesCompte()
        {
            return repository.FindAll();
        }

    }
}
