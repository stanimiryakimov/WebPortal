﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebPortal.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int Department_id { get; set; }
        public string Event_begin_date { get; set; }
        public string Event_begin_time { get; set; }
        public string Event_end_date { get; set; }
        public string Event_end_time { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
    }
}