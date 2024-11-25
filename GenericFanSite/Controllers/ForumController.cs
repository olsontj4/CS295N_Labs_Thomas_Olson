using GenericFanSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

using GenericFanSite.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GenericFanSite.Controllers
{
    public class ForumController : Controller
    {
        IForumRepository repo; //Not sure if this should be private or not.
        public ForumController(IForumRepository r)
        {
            repo = r;
        }
        public IActionResult Index()
        {
            var forumPosts = repo.GetAllForumPosts();
            return View(forumPosts);
        }
        public IActionResult ForumPostForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForumPostForm(ForumPost data)
        {
            /*if (!ModelState.IsValid) //TODO: Different validation.
            {

            }*/
            try
            {
                if (repo.StoreForumPost(data) > 0)
                {
                    return RedirectToAction("Index", new { forumPostId = data.ForumPostId });// Not sure what I'm using the ID for.
                }
                else
                {
                    ViewBag.RedText = "There was a really bad error saving the forum post.";
                    return View();
                }
            }
            catch
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
        }
    }
}
