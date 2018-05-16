using System;
using System.Linq;
using System.Web.Mvc;
using WebPortal.Data;

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
            context.Events.Add(new Models.EntityFrameworkModels.Event()
            {
                BeginDate = DateTime.Now,
                Description = "Test Event",
                Url = "https://metafication.com",
                EndDate = DateTime.Now,
                DepartmentId = 10,
                Location = "UNSS"
            });
            context.SaveChanges();
            var allEvents = context.Events.ToList();

            //var moodleResources = dataProvider.GetAllMoodleResources();
            
            ViewBag.Message = "Your contact page.";

            var result = dataProvider.GetAllEvents();
            var moodleResources = dataProvider.GetAllMoodleResources();
            var news = dataProvider.GetAllNews();

            return View(moodleResources);
        }
    }
}