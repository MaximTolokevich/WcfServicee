using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Web.UI;
using WcfMVC.Models;
using WcfService;

namespace WcfMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("Sum")]
        public IActionResult Sum(int a , int b)
        {
            Service1 service = new();

            SumResModel model = new()
            {
                Result = service.Sum(a, b)
            };
            
            return View(model);
        }
    }
}
