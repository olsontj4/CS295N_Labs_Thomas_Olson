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
        public IActionResult Index(String? name, DateTime? date, String? filter, int results)
        {
            if (results == 0)  //Default for number of forum posts displayed is 3.
            {
                results = 3;
            }
            else if (results == -1)  //Display all.
            {
                results = repo.GetAllForumPosts().ToList().Count();
            }
            if (filter == "Name")
            {
                var forumPosts = repo.GetAllForumPosts()
                    .Where(p => name == null || p.User.Name == name)
                    .Where(p => date == null || p.Date == date)
                    .OrderBy(p => p.User.Name)
                    .Take(results)  //Using .Take() to not display every row in the database table.
                    .ToList();
                return View(forumPosts);
            }
            else
            {
                var forumPosts = repo.GetAllForumPosts()
                    .Where(p => name == null || p.User.Name == name)
                    .Where(p => date == null || p.Date == date)
                    .OrderByDescending(p => p.Date)
                    .Take(results)
                    .ToList();
                return View(forumPosts);
            }
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