using System.Data.Entity;
using WebPortal.Models.EntityFrameworkModels;

namespace WebPortal.Data
{
    public class WebPortalContext : DbContext
    {
        public WebPortalContext() : base("EfConnectionString")
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<MoodleResource> MoodleResource { get; set; }
        public DbSet<News> News { get; set; }
    }
}