using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using testtieplan4.Models;

namespace testtieplan4.Controllers
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
        public IActionResult elements()
        {
            return View();
        }
        public IActionResult e404()
        {
            return View();
        }
        public IActionResult blogarticle()
        {
            return View();
        }
        public IActionResult blogfullwidth()
        {
            return View();
        }
        public IActionResult bloggrid()
        {
            return View();
        }
        public IActionResult bloglist()
        {
            return View();
        }
        public IActionResult comingsoon()
        {
            return View();
        }
        public IActionResult documentation()
        {
            return View();
        }
        public IActionResult forum()
        {
            return View();
        }
        public IActionResult forumsingletopic()
        {
            return View();
        }
        public IActionResult forumtopics()
        {
            return View();
        }
        public IActionResult gallery()
        {
            return View();
        }
        public IActionResult news()
        {
            return View();
        }
        public IActionResult offline()
        {
            return View();
        }
        public IActionResult store()
        {
            return View();
        }
        public IActionResult storecart()
        {
            return View();
        }
        public IActionResult storecatalog()
        {
            return View();
        }
        public IActionResult storecatalogalt()
        {
            return View();
        }
        public IActionResult storecheckout()
        {
            return View();
        }
        public IActionResult storeproduct()
        {
            return View();
        }
        public IActionResult tournaments()
        {
            return View();
        }
        public IActionResult tournamentsteammate()
        {
            return View();
        }
        public IActionResult tournamentsteams()
        {
            return View();
        }
        public IActionResult widgets()
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
    }
}