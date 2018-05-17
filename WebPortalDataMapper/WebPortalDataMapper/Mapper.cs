using System;

namespace WebPortalDataMapper
{
    public static class Mapper
    {
        public static DatabaseConnection.MoodleResource MapResource(UnweConnection.MoodleResource moodleResource)
        {
            return new DatabaseConnection.MoodleResource()
            {
                Id = moodleResource.Id,
                ResourceType = moodleResource.Resource_Type,
                Added = ConvertToDate(moodleResource.Added),
                Course = moodleResource.Course,
                Description = moodleResource.Description,
                Fn = moodleResource.Fn
            };
        }

        public static DatabaseConnection.News MapNews(UnweConnection.News news)
        {
            return new DatabaseConnection.News()
            {
                Id = news.Id,
                Description = news.Description,
                DepartmentId = news.Department_Id,
                Published = ConvertToDate(news.Published)
            };
        }

        public static DatabaseConnection.Event MapEvent(UnweConnection.Event particularEvent)
        {
            return new DatabaseConnection.Event
            {
                BeginDate = ConvertToDateTime(particularEvent.Event_begin_date, particularEvent.Event_begin_time),
                EndDate = ConvertToDateTime(particularEvent.Event_end_date, particularEvent.Event_end_time),
                DepartmentId = particularEvent.Department_id,
                Description = particularEvent.Description,
                Id = particularEvent.Id,
                Location = particularEvent.Location,
                Url = particularEvent.Url
            };
        }

        public static DateTime ConvertToDate(string dateInString)
        {
            return dateInString != "" ? 
                Convert.ToDateTime(dateInString, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat) 
                : DateTime.Now;
        }

        public static DateTime ConvertToDateTime(string dateInString, string timeInString)
        {
            var dateResult = ConvertToDate(dateInString);

            //if (timeInString == "")
            //{
            //    timeInString = "00:00:00";
            //}

            string[] timeArgs = timeInString.Split(':');
            

            var newDate = new DateTime(
                dateResult.Date.Year,
                dateResult.Date.Month,
                dateResult.Date.Day,
                int.Parse(timeArgs[0]),
                int.Parse(timeArgs[1]),
                int.Parse(timeArgs[2]));
            return newDate;
        }
    }
}
