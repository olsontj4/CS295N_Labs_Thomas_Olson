using GenericFanSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Nodes;

namespace GenericFanSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }
        public IActionResult Stories()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Quiz()
        {
            Quiz model = new Quiz();
            return View(model);
        }
        [HttpPost]
        public IActionResult Quiz(IEnumerable<string> answers)
        {
            Quiz model = new Quiz();
            for (int i = 0; i < model.Questions.Count; i++)
            {
                model.Questions[i].UserA = answers.ToString();
            }
            // TODO: Use this parameter.
            return View(model);
        }
    }
}