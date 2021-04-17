using System.Web;
using System.Web.Mvc;

namespace Guia4_ADS_CrudCarrera
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
