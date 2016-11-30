using System.Web.Mvc;

namespace Prnewswire.PortalNoZero.Web.Controllers
{
    public class HomeController : PortalNoZeroControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}