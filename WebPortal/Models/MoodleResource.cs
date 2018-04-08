using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPortal.Models
{
    public class MoodleResource
    {
        public int Id { get; set; }
        public string Fn { get; set; }
        public string Course { get; set; }
        public string Resource_Type { get; set; }
        public string Added { get; set; }
        public string Description { get; set; }
    }
}