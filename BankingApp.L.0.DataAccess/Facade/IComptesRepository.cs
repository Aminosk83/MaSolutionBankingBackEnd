using BankingApp.L._0.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L._0.DataAccess.Facade
{
    public interface IComptesRepository
    {
        // CRUD Contract

        void Create(Compte compte);
        void Update(Compte compte);
        void Delete(string id);

        Compte FindById(string id);

        IEnumerable<Compte> FindAll(); //
    }
}
