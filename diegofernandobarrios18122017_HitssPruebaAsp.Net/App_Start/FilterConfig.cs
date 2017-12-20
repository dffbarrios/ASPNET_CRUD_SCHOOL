using System.Web;
using System.Web.Mvc;

namespace diegofernandobarrios18122017_HitssPruebaAsp.Net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
