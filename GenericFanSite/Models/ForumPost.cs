namespace GenericFanSite.Models
{
    public class ForumPost
    {
        /*    Title of the story

    Topic

    Year the story took place (an integer)

    Text of the story

    Name of the submitter (AppUser)

    Date submitted*/
        public string ForumTitle { get; set; }
        public string ForumDescription { get; set; }
        public int ForumYear { get; set;}
        public string ForumText { get; set; }
        public string ForumUser { get; set; }
        public DateTime ForumDate { get; set; }
    }
}
