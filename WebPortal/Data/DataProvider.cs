using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WebPortal.Models;

namespace WebPortal.Data
{
    public class DataProvider
    {
        public List<Event> GetAllEvents()
        {
            List<Event> result = new List<Event>();
            using (IDbConnection db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                result = db.Query<Event>(
                    "select * from dbo.v_events").ToList();
            }

            return result;
        }

        public List<MoodleResource> GetAllMoodleResources()
        {
            List<MoodleResource> moodleResources = new List<MoodleResource>();
            using (IDbConnection db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                moodleResources = db.Query<MoodleResource>(
                    "select * from dbo.v_moodle").ToList();
            }

            return moodleResources;
        }

        public List<News> GetAllNews()
        {
            List<News> news = new List<News>();
            using (IDbConnection db = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                news = db.Query<News>(
                    "select * from dbo.v_news").ToList();
            }

            return news;
        }
    }
}