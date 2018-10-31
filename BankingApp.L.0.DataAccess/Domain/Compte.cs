using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L._0.DataAccess.Domain
{
    public class Compte
    {
        [Key]
        public string Numero { get; set; }

        public string Propiertaire { get; set; }

        public decimal Solde { get; set; }

        public void Débiter(decimal montant)
        {
            Solde += montant;
        }

        public void crediter(decimal montant)
        {
            Solde -= montant;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Compte converti = obj as Compte;

            return Numero.Equals(converti.Numero);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }
    }
}
