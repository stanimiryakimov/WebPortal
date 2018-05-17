using System;
using System.Linq;
using System.Web.Mvc;
using WebPortal.Data;
using WebPortal.Mappers;

namespace WebPortal.Controllers
{
    public class HomeController : Controller
    {
        private UnweResourceService dataProvider;
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

        public ActionResult Contact()
        {
            dataProvider = new UnweResourceService();
            context = new WebPortalContext();
            
            var moodleRes = dataProvider.GetAllMoodleResources();
            var resource = Mapper.MapResource(moodleRes[0]);

            ViewBag.Message = "Your contact page.";

            var result = dataProvider.GetAllEvents();
            var moodleResources = dataProvider.GetAllMoodleResources();
            var news = dataProvider.GetAllNews();

            return View(moodleResources);
        }
    }
}