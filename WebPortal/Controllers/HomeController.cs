using System.Linq;
using System.Web.Mvc;
using WebPortal.Data;

namespace WebPortal.Controllers
{
    public class HomeController : Controller
    {
        private WebPortalContext context;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Events()
        {
            context = new WebPortalContext();
            var allEvents = context.Events.ToList();
            return View(allEvents);
        }
    }
}