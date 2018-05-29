using System.Collections.Generic;
    
namespace WebPortal.Models.EntityFrameworkModels
{
    public class Resources
    {
        public List<Event> Events { get; set; }
        public List<MoodleResource> MoodleResources { get; set; }
        public List<News> News { get; set; }
    }
}