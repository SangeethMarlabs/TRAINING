using System.Web;
using System.Web.Mvc;

namespace ViewBag_Multiple_Records
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
