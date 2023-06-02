using Microsoft.AspNetCore.Mvc;
using MvcDemoPractice.Models;

namespace MvcDemoPractice.Controllers
{
    public class Login : Controller
    {
       
        public IActionResult login()
        {
            var logins = new List<LoginRepo>
			{
                new LoginRepo{Name="Tejaswini",Password="12345"},
				 new LoginRepo{Name="Swathi",Password="123"},
			};
          
            ViewData["logins"] = logins;
             return View();
        }
	}
}
