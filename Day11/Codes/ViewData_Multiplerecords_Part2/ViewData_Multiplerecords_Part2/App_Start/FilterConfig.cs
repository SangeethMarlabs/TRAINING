﻿using System.Web;
using System.Web.Mvc;

namespace ViewData_Multiplerecords_Part2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
