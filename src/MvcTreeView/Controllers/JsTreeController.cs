using System.Web.Mvc;

namespace MvcTreeView.Controllers
{
    public class JsTreeController : Controller
    {
        public ActionResult Index()
        {
            var locations = TreeViewController.GetLocations();
            return View(locations);
        }

    }
}
