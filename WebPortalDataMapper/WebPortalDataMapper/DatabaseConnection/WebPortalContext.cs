using System.Data.Entity;

namespace WebPortalDataMapper.DatabaseConnection
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
