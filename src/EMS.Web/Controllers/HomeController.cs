﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace EMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : EMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}