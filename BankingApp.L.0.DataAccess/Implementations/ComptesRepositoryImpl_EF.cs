using BankingApp.L._0.DataAccess.Domain;
using BankingApp.L._0.DataAccess.Facade;
using BankingApp.L._0.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L._0.DataAccess.Implementations
{
    public class ComptesRepositoryImpl_EF : IComptesRepository
    {
        public void Create(Compte compte)
        {
            using (var ctxt = new BankingContext())
            {
                ctxt.Comptes.Add(compte);
                ctxt.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compte> FindAll()
        {
            using (var ctxt = new BankingContext())
            {
                return ctxt.Comptes.ToList();
            }
        }

        public Compte FindById(string id)
        {
            using (var ctxt = new BankingContext())
            {
                return ctxt.Comptes.Find(id);
            }
        }

        public void Update(Compte compte)
        {
            throw new NotImplementedException();
        }
    }
}
