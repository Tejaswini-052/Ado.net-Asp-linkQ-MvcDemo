using AspnetwebappDemo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspnetwebappDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepo EmployeeInfo;

        public IndexModel(IEmployeeRepo EmployeeInfoRepo)
        {
            EmployeeInfo = EmployeeInfoRepo;
        }

        public void OnGet()
        {
            ViewData["Id"]= EmployeeInfo.GetEmployeeInfo().Id;
            ViewData["Name"] = EmployeeInfo.GetEmployeeInfo().Name;
        }
    }
}