﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebPortal.Models.EntityFrameworkModels
{
    public class MoodleResource : IMoodleResource
    {
        [Key]
        public int Id { get; set; }
        public string Fn { get; set; }
        public string Course { get; set; }
        public string ResourceType { get; set; }
        public DateTime Added { get; set; }
        public string Description { get; set; }
        public bool IsFavourite { get; set; }
    }
}