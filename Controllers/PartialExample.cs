using Microsoft.AspNetCore.Mvc;

namespace MvcDemoPractice.Controllers
{
    public class PartialExample : Controller
    {
        public IActionResult PartialViewPraticeDemo()
        {
            return View();
        }
    }
}
