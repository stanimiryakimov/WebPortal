using System;

namespace WebPortal.Models.EntityFrameworkModels
{
    public class News : INews
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public DateTime Published { get; set; }
        public string Description { get; set; }
        public bool IsFavourite { get; set; }
    }
}