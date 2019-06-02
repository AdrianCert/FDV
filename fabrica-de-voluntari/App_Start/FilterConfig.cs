using System.Web;
using System.Web.Mvc;

namespace fabrica_de_voluntari
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
