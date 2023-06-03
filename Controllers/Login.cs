using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcDemoPractice.Models;

namespace MvcDemoPractice.Controllers
{
    public class Login : Controller
    {
        //[ViewData]
        //public string Title{get;set;}
        public IActionResult login()
        {
            //TempData["Name"] = "Tejaswini";

            //ViewBag.Log=LoginRepo;
            //var logins = new List<LoginRepo>
            //{
            //    new LoginRepo{Name="Tejaswini",Password="12345"},
            //     new LoginRepo{Name="Swathi",Password="123"},
            //};
            //ViewData["name"]="Login Creds";
            //ViewData["title"]="Credentials";
           // ViewData["logins"] = logins;


            //var newLogin = new LoginRepo{

            //Name="Tejaswini",
            //Password="Tej/2002"
            //};
            //return View(newLogin);

            //var activity = new LoginActivity{

            //logins=new newLogin,
            //Activity="Logging in"
            //};
            //return View(activity);
            string name;
            if (TempData.ContainsKey("Name"))
                name = TempData["Name"].ToString();
            return View();


           // return View();
        }
	}
}
