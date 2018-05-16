using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPortal.Models.EntityFrameworkModels;

namespace WebPortal.Mappers
{
    public class Mapper
    {
        public MoodleResource MapResource(Models.MoodleResource moodleResource)
        {
            return new MoodleResource()
            {
                Id = moodleResource.Id,
                ResourceType = moodleResource.Resource_Type
            };
        }
    }
}