using GenericFanSite.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericFanSite.Data
{
    public class ApplicationDbContext : DbContext
    {
        // constructor just calls the base class constructor
        public ApplicationDbContext(
           DbContextOptions<ApplicationDbContext> options) : base(options) { }
        // one DbSet for each domain model class
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
