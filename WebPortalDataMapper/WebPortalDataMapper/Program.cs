using System;
using System.Data.Entity.Migrations;
using System.Threading;
using WebPortalDataMapper.DatabaseConnection;
using WebPortalDataMapper.UnweConnection;

namespace WebPortalDataMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // 0
                Thread.Sleep(10000);
                SyncDatabase();
            }
        }

        private static void SyncDatabase()
        {
            var unweService = new UnweResourceService();
            var resources = unweService.GetAllMoodleResources();
            var news = unweService.GetAllNews();
            var events = unweService.GetAllEvents();

            var dbContext = new WebPortalContext();

            foreach (var resource in resources)
            {
                DatabaseConnection.MoodleResource currentResource = Mapper.MapResource(resource);
                dbContext.MoodleResource.AddOrUpdate(currentResource);
                dbContext.SaveChanges();
            }

            foreach (var particularNews in news)
            {
                DatabaseConnection.News currentNews = Mapper.MapNews(particularNews);
                dbContext.News.AddOrUpdate(currentNews);
                dbContext.SaveChanges();
            }

            foreach (var particularEvent in events)
            {
                if (particularEvent.Event_end_date != "" && particularEvent.Event_begin_date != "")
                {
                    DatabaseConnection.Event currentEvent = Mapper.MapEvent(particularEvent);
                    dbContext.Events.AddOrUpdate(currentEvent);
                    dbContext.SaveChanges();
                }
            }
            
            Console.WriteLine("Database Synched!");
        }
    }
}
