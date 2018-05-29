using System;

namespace WebPortal.Models.EntityFrameworkModels
{
    public interface IEvent
    {
        int Id { get; set; }
        int DepartmentId { get; set; }
        DateTime BeginDate { get; set; }
        DateTime EndDate { get; set; }
        string Description { get; set; }
        string Location { get; set; }
        string Url { get; set; }
        bool IsFavourite { get; set; }
    }
}