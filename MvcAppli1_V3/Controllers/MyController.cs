using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAppli1_V3.Controllers
{
    public class MyController : Controller
    {
        //
        // GET: /My/

        public string Index()
        {
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }

    }
}
