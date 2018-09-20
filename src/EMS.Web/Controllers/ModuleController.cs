using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS.Web.Controllers
{
    public class ModuleController : EMSControllerBase
    {
        // GET: Module
        public ActionResult Index()
        {
            return View();
        }
    }
}