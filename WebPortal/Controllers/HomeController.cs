using System.Linq;
using System.Web.Mvc;
using WebPortal.Data;
using WebPortal.Models.EntityFrameworkModels;

namespace WebPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebPortalContext context;

        public HomeController(WebPortalContext webPortalContext)
        {
            context = webPortalContext;
        }

        public ActionResult Index()
        {
            var pinnedEvents = context.Events
                .Where(e => e.IsFavourite == true)
                .OrderBy(e => e.BeginDate)
                .ToList();
            
            var pinnedNews = context.News
                .Where(n => n.IsFavourite == true)
                .OrderBy(e => e.Published)
                .ToList();

            Resources resources = new Resources();
            resources.Events = pinnedEvents;
            resources.News = pinnedNews;

            return View(resources);
        }

        public ActionResult News()
        {
            var allNews = context.News.ToList();

            return View(allNews);
        }

        public ActionResult Events()
        {
            var allEvents = context.Events.ToList();
            return View(allEvents);
        }

        public ActionResult GetLatestEvents()
        {
            var fiveLatestEvents = context.Events
                .OrderByDescending(a => a.BeginDate).Take(5).ToList();

            return View(fiveLatestEvents);
        }

        public ActionResult GetLatestNews()
        {
            var fiveLatestNews = context.News
                .OrderByDescending(a => a.Published).Take(5).ToList();

            return View(fiveLatestNews);
        }

        public ActionResult GetLastResources()
        {
            var lastResources = context.MoodleResource
                .OrderByDescending(a => a.Description).Distinct().Take(5).ToList();

            return View(lastResources);
        }

        [HttpPost]
        public ActionResult SetAsFavourite(int particularEventId)
        {
            var particularEvent = context.Events
                .FirstOrDefault(e => e.Id == particularEventId);

            particularEvent.IsFavourite = true;

            context.SaveChanges();

            return RedirectToAction("Events");
        }

        [HttpPost]
        public ActionResult SetNewsAsFavourite(int particularNewsId)
        {
            var particularNews = context.News
                .FirstOrDefault(n => n.Id == particularNewsId);

            particularNews.IsFavourite = true;

            context.SaveChanges();

            return RedirectToAction("News");
        }

        [HttpPost]
        public ActionResult RemoveEventFromFavourite(int particularEventId)
        {
            var particularEvent = context.Events
                .FirstOrDefault(e => e.Id == particularEventId);

            particularEvent.IsFavourite = false;

            context.SaveChanges();

            return RedirectToAction("Events");
        }

        [HttpPost]
        public ActionResult RemoveNewsFromFavourite(int particularNewsId)
        {
            var particularNews = context.News
               .FirstOrDefault(n => n.Id == particularNewsId);

            particularNews.IsFavourite = false;

            context.SaveChanges();

            return RedirectToAction("News");
        }
    }
}