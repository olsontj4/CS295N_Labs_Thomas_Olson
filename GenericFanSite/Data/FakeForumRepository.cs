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
        ForumPost IForumRepository.GetForumPostById(int id)
        {
            throw new NotImplementedException();
        }
        int IForumRepository.StoreForumPost(ForumPost model)
        {
            throw new NotImplementedException();
        }
    }
}
