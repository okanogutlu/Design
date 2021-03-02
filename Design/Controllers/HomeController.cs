using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Design.Models;

namespace Design.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult AboutMe()
        {
            return View();
            
        }
        public IActionResult Contact()
        {
            return View();

        }
        public IActionResult ContentDetail(int id)
        {
            var content = ModelRepository._contents.Where(i => i.Id == id).FirstOrDefault();
            return View(content);

        }
        public IActionResult MyPortfolio()
        {
            return View();

        }
        public IActionResult ProjectDetail()
        {
            return View();

        }

        public IActionResult Index()
        {
            return View(ModelRepository._contents);
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
