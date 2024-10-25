namespace GenericFanSite.Models
{
    public class ForumPost
    {
    /*Title of the story

    Topic

    Year the story took place (an integer)

    Text of the story

    Name of the submitter (AppUser)

    Date submitted*/
        public string ForumTitle { get; set; }
        public string ForumDescription { get; set;}
        public int ForumYear { get; set;}
        public string ForumText { get; set;}
        public AppUser ForumUser { get; set;}
        public DateTime ForumDate { get; set;}
        /*public ForumPost(string forumTitle, string forumDescription, int forumYear, string forumText, string forumUser, DateTime forumDate)
        {
            ForumTitle = forumTitle;
            ForumDescription = forumDescription;
            ForumYear = forumYear;
            ForumText = forumText;
            ForumUser = forumUser;
            ForumDate = forumDate;
        }
        private string forumTitle;
        private string forumDescription;
        private int forumYear;
        private string forumText;
        private string forumUser;
        private DateTime forumDate;
        public string ForumTitle {
            get
            {
                return forumTitle;
            }
            set
            {
                if (value.Trim().Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Please enter a title.");
                }
                else if (value.Trim().Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Character limit is 50.");
                }
                else
                {
                    forumTitle = value.Trim();
                }
            }
        }
        public string ForumDescription
        {
            get
            {
                return forumDescription;
            }
            set
            {
                if (value.Trim().Length > 100)
                {
                    throw new ArgumentOutOfRangeException("Character limit is 100.");
                }
                else
                {
                    forumDescription = value.Trim();
                }
            }
        }
        public int ForumYear
        {
            get
            {
                return forumYear;
            }
            set
            {
                if (value < 1987)
                {
                    throw new ArgumentOutOfRangeException("Please enter a more recent year.");
                }
                else if (value > DateTime.Now.Year)  //I'm curious if someone could change the time on their computer to circumvent this validation...
                {
                    throw new ArgumentOutOfRangeException("Year cannot be in the future.");
                }
                else
                {
                    forumYear = value;
                }
            }
        }
        public string ForumText
        {
            get
            {
                return forumText;
            }
            set
            {
                if (value.Trim().Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Please enter text.");
                }
                else if (value.Trim().Length > 10000)
                {
                    throw new ArgumentOutOfRangeException("Character limit is 10000.");
                }
                else
                {
                    forumText = value.Trim();
                }
            }
        }
        public string ForumUser
        {
            get
            {
                return forumUser;
            }
            set
            {
                forumUser = value;
            }
        }
        public DateTime ForumDate
        {
            get
            {
                return forumDate;
            }
            set
            {
                forumDate = DateTime.Now;
            }
        }*/
        //TODO: Validate setters.
    }
}
