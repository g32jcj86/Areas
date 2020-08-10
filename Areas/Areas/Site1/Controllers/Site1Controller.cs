using Areas.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Areas.Site1.Controllers
{
    [CustomRole]
    public class Site1Controller : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}