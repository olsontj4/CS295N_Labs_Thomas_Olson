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
                if (data.ForumTitle == null)
                {
                    ViewBag.RedText = "Please add a title.";
                }
                else if (data.ForumDescription == null)
                {
                    ViewBag.RedText = "Please add a description.";
                }
                else if (data.ForumText == null)
                {
                    ViewBag.RedText = "Please write a story.";
                }
                else if (data.ForumYear == null)
                {
                    ViewBag.RedText = "Please enter a year.";
                }
                else if (data.ForumUser == null)
                {
                    ViewBag.RedText = "Please enter your name.";
                }
                else
                {
                    ViewBag.RedText = "An unknown error has occured.";
                }
                return View(data);
            }
            return RedirectToAction("Index");
        }
    }
}
