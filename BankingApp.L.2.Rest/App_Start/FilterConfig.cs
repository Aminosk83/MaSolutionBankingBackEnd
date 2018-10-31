using System.Web;
using System.Web.Mvc;

namespace BankingApp.L._2.Rest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
