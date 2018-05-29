using System;

namespace WebPortal.Models.EntityFrameworkModels
{
    public interface IMoodleResource
    {
        int Id { get; set; }
        string Fn { get; set; }
        string Course { get; set; }
        string ResourceType { get; set; }
        DateTime Added { get; set; }
        string Description { get; set; }
        bool IsFavourite { get; set; }
    }
}