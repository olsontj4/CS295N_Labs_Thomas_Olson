using GenericFanSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace GenericFanSite.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            ForumPost model = new ForumPost();
            return View(model);
        }
        public IActionResult ForumPostForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForumPostForm(ForumPost data)
        {
            data.ForumDate = DateTime.Now;
            return View("Index", data);
        }
    }
}
