﻿using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Framework_Oracle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
