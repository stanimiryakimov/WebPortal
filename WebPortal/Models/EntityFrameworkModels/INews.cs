using System;

namespace WebPortal.Models.EntityFrameworkModels
{
    public interface INews
    {
        int Id { get; set; }
        int DepartmentId { get; set; }
        DateTime Published { get; set; }
        string Description { get; set; }
        bool IsFavourite { get; set; }
    }
}