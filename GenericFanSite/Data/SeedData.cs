using System.Runtime.Intrinsics.X86;
using System;
using GenericFanSite.Models;

namespace GenericFanSite.Data
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.ForumPosts.Any())  // this is to prevent adding duplicate data
            {
                // Create User objects
                AppUser user1 = new AppUser { Name = "Thomasj041" };
                AppUser user2 = new AppUser { Name = "Gilzor" };
                // Queue up user objects to be saved to the DB
                context.AppUsers.Add(user1);
                context.AppUsers.Add(user2);
                context.SaveChanges();  // Saving adds UserId to User objects
                ForumPost forumPost1 = new ForumPost
                {
                    Title = "Cool new album!",
                    Description = "Review of the Paradise State of Mind album",
                    Year = 2024,
                    Story = "This album sounds pretty good.",
                    User = user1,
                    Date = DateTime.Parse("11/25/2024")
                };
                context.ForumPosts.Add(forumPost1);  // queues up a review to be added to the DB
                context.SaveChanges(); // stores all the reviews in the DB
            }
        }
    }
}