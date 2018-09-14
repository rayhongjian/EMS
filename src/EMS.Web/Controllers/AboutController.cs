using System.Web.Mvc;

namespace EMS.Web.Controllers
{
    public class AboutController : EMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}