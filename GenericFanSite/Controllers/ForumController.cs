using GenericFanSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

using GenericFanSite.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace GenericFanSite.Controllers
{
    public class ForumController : Controller
    {
        ApplicationDbContext context;
        public ForumController(ApplicationDbContext c)
        {
            context = c;
        }
        public IActionResult Index()
        {
            //ForumPost model = new ForumPost();
            List<ForumPost> forumPosts = context.ForumPosts
                .Include(forumPost => forumPost.ForumUser)
                .ToList();
            return View(forumPosts);
        }
        public IActionResult ForumPostForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForumPostForm(ForumPost data)
        {
            try
            {
                data.ForumDate = DateTime.Now;
                context.ForumPosts.Add(data);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return View(data);
            }
            //return View("Index", data);
            return RedirectToAction("Index");
        }
    }
}
