using System.Web;
using System.Web.Mvc;

namespace sang4_tuan4_3970_LeQuocTrinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
