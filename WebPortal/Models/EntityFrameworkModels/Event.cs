using System;
using System.ComponentModel.DataAnnotations;

namespace WebPortal.Models.EntityFrameworkModels
{
    public class Event : IEvent
    {
        [Key]
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public bool IsFavourite { get; set; }
    }
}