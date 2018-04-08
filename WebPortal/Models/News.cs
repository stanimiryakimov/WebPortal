namespace WebPortal.Models
{
    public class News
    {
        public int Id { get; set; }
        public int Department_Id { get; set; }
        public string Published { get; set; }
        public string Description { get; set; }
    }
}