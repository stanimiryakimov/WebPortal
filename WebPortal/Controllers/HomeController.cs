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

        public ActionResult GetLatestEvents()
        {
            context = new WebPortalContext();

            var fiveLatestEvents = context.Events
                .OrderByDescending(a => a.BeginDate).Take(5).ToList();

            return View(fiveLatestEvents);
        }

        public ActionResult GetLatestNews()
        {
            context = new WebPortalContext();

            var fiveLatestNews = context.News
                .OrderByDescending(a => a.Published).Take(5).ToList();

            return View(fiveLatestNews);
        }

        public ActionResult GetLastResources()
        {
            context = new WebPortalContext();

            var lastResources = context.MoodleResource
                .OrderByDescending(a => a.Description).Distinct().Take(5).ToList();

            return View(lastResources);
        }
    }
}