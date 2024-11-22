using GenericFanSite.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericFanSite.Data
{
    public class ForumRepository : IForumRepository
    {
        private ApplicationDbContext context;
        public ForumRepository(ApplicationDbContext appDbContext)
        {
            context = appDbContext;
        }
        List<ForumPost> IForumRepository.GetAllForumPosts()
        {
            var forumPosts = context.ForumPosts
                .Include(forumPost => forumPost.ForumUser)
                .ToList();
            return forumPosts;
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
