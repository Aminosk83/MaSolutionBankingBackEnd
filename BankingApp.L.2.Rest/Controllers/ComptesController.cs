using BankingApp.L._0.DataAccess.Domain;
using BankingApp.L._1.Business.Facade;
using BankingApp.L._1.Business.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BankingApp.L._2.Rest.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class ComptesController : ApiController
    {
        //private ICompteBusiness busniness = new CompteBusniessImpl();
        private ICompteBusiness busniness;

        public ComptesController(ICompteBusiness busniness)
        {
            this.busniness = busniness;
        }

        // GET api/comptes
        public IEnumerable<Compte> Get()
        {
            return busniness.TousLesCompte();
        }
    }
}
