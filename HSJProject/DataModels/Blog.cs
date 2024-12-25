using System.ComponentModel.DataAnnotations;

namespace HSJProject.DataModels
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogContent { get; set; }
        public string? BlogThumbnails { get; set; }
    }
}
