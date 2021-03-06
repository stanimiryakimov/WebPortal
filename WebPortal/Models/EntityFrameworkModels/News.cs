﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebPortal.Models.EntityFrameworkModels
{
    public class News : INews
    {
        [Key]
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public DateTime Published { get; set; }
        public string Description { get; set; }
        public bool IsFavourite { get; set; }
    }
}