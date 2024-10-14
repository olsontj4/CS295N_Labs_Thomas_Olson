using Microsoft.AspNetCore.Mvc;

namespace GenericFanSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
