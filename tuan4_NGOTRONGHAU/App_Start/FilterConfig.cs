﻿using System.Web;
using System.Web.Mvc;

namespace tuan4_NGOTRONGHAU
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
