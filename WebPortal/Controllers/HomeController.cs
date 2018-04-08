using System.Web.Mvc;
using WebPortal.Data;

namespace WebPortal.Controllers
{
    public class HomeController : Controller
    {
        private DataProvider dataProvider;

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
            dataProvider = new DataProvider();
            ViewBag.Message = "Your contact page.";

            var result = dataProvider.GetAllEvents();
            var moodleResources = dataProvider.GetAllMoodleResources();
            var news = dataProvider.GetAllNews();
            return View();
        }
    }
}