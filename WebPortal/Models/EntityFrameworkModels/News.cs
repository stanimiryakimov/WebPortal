﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPortal.Models.EntityFrameworkModels
{
    public class News
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public DateTime Published { get; set; }
        public string Description { get; set; }
        public bool IsFavourite { get; set; }
    }
}