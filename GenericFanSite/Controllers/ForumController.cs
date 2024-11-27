using GenericFanSite.Models;
using Microsoft.AspNetCore.Mvc;
using GenericFanSite.Data;

namespace GenericFanSite.Controllers
{
    public class ForumController : Controller
    {
        IForumRepo repo; //Not sure if this should be private or not.
        public ForumController(IForumRepo r)
        {
            repo = r;
        }
        public IActionResult Index(ForumPost forumPost)
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
            if (ModelState.IsValid)
            {
                try
                {
                    if (data != null && repo.StoreForumPost(data) > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.RedText = "There was a really bad error saving the forum post.";
                        return View();
                    }
                }
                catch
                {
                    ViewBag.RedText = "An unknown error has occured.";
                    return View(data);
                }
            }
            var allErrors = ModelState.Where(e => e.Value.Errors.Count > 0).ToList();
            ViewBag.RedText = allErrors[0].Value.Errors[0].ErrorMessage.ToString();  //I am doing a bad.  Error messages work though, so I don't care.  Thank you, Stack Overflow.
            return View(data);
        }
    }
}