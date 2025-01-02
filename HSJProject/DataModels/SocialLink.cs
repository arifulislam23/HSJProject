using System.ComponentModel.DataAnnotations;

namespace HSJProject.DataModels
{
    public class SocialLink
    {
        [Key]
        public int SocialLinkId { get; set; } // e.g., "Facebook", "Twitter"
        public string Platform { get; set; } // e.g., "Facebook", "Twitter"
        public string Url { get; set; }      // e.g., "https://facebook.com/yourpage"
        public string IconClass { get; set; } // e.g., "fa-facebook"
        //public bool IsActive { get; set; } // e.g., "fa-facebook"
    }
}
