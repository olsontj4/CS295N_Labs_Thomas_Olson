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
            var review = context.ForumPosts
                .Include(forumPost => forumPost.ForumUser) // returns AppUser object
                .Where(forumPost => forumPost.ForumPostId == id)
                .SingleOrDefault();
            return review;
        }
        int IForumRepository.StoreForumPost(ForumPost data)
        {
            data.ForumDate = DateTime.Now;
            context.ForumPosts.Add(data);
            return context.SaveChanges();
            // returns a positive value if succussful
        }
    }
}
