using System.Web;
using System.Web.Mvc;

namespace Aplicación_web_ASP_NET_Framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
