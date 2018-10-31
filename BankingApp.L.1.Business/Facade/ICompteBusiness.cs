using BankingApp.L._0.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L._1.Business.Facade
{
    public interface ICompteBusiness
    {
        decimal? ConsulterSolde(string numero);
        IEnumerable<Compte> TousLesCompte();
    }
}
