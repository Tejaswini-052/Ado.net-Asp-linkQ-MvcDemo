using Microsoft.AspNetCore.Mvc;
using MvcDemoPractice.Models;
using System.Diagnostics;

namespace MvcDemoPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



  //      private readonly ILogin Login;

		//public HomeController(ILogin LoginRepo)
		//{
  //          Login = LoginRepo;
		//}

  //      public void OnGet()
  //      {
  //          ViewData["Name"] = Login.GetInfo().Name;
		//	ViewData["Password"] = Login.GetInfo().Password;

		//}


		public IActionResult Index()
        {
            return View();
        }
        public IActionResult department()
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