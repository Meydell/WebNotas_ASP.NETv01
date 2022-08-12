using System.Web;
using System.Web.Mvc;

namespace WebNotas_ASP.NETv01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
