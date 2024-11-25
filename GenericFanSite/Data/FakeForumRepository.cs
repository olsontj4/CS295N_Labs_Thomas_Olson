using GenericFanSite.Models;

namespace GenericFanSite.Data
{
    public class FakeForumRepository : IForumRepository
    {
        private List<ForumPost> forumPosts = new List<ForumPost>();
        List<ForumPost> IForumRepository.GetAllForumPosts()
        {
            throw new NotImplementedException();
        }
        public ForumPost GetForumPostById(int id)
        {
            ForumPost forumPost = forumPosts.Find(f => f.ForumPostId == id);
            return forumPost;
        }
        int IForumRepository.StoreForumPost(ForumPost model)
        {
            int status = 0;
            if (model != null)
            {
                model.ForumPostId = forumPosts.Count + 1;
                forumPosts.Add(model);
                status = 1;
            }
            return status;
        }
    }
}