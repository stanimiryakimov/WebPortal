using System;
using WebPortal.Models.EntityFrameworkModels;

namespace WebPortal.Mappers
{
    public static class Mapper
    {
        public static MoodleResource MapResource(Models.MoodleResource moodleResource)
        {
            return new MoodleResource()
            {
                Id = moodleResource.Id,
                ResourceType = moodleResource.Resource_Type,
                Added = Convert.ToDateTime(moodleResource.Added),
                Course = moodleResource.Course,
                Description = moodleResource.Description,
                Fn = moodleResource.Fn                
            };
        }
        
    }
}