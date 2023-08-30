using System.Web;
using System.Web.Mvc;

namespace Marlabs_Customer_DatabaseConnectivity_Ex2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
