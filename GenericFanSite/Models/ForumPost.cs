using System.ComponentModel.DataAnnotations;

namespace GenericFanSite.Models
{
    public class ForumPost
    {
        public int ForumPostId { get; set; }
        [Required]
        public string? ForumTitle { get; set; }
        [Required]
        public string? ForumDescription { get; set;}
        [Required]
        [Range(1987, 9999, ErrorMessage = "Please enter a different year.")]
        public int? ForumYear { get; set;}
        [Required]
        public string? ForumText { get; set;}
        [Required]
        public AppUser ForumUser { get; set;}
        public DateTime ForumDate { get; set;}
        //TODO: Validate setters.
    }
}
