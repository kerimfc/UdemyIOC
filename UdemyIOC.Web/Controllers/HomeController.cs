using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UdemyIOC.Web.Models;

namespace UdemyIOC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ISingletonDateService _singletonDateService;

        private readonly IScopeDateService _scopeDateService;

        private readonly ITransientDateService _transientDateService;

        public HomeController(ILogger<HomeController> logger, ISingletonDateService singletonDateService, IScopeDateService scopeDateService, ITransientDateService transientDateService)
        {
            _logger = logger;
            _singletonDateService = singletonDateService;
            _scopeDateService = scopeDateService;
            _transientDateService = transientDateService;
        }

        public IActionResult Index([FromServices] IScopeDateService scopeDateService2)
        {
            ViewBag.time1 = _scopeDateService.GetDateTime.TimeOfDay.ToString();

            ViewBag.time2 = scopeDateService2.GetDateTime.TimeOfDay.ToString();

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