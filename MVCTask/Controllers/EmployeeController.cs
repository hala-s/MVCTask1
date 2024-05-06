using Microsoft.AspNetCore.Mvc;
using MVCTask.Data;

namespace MVCTask.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context=new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees= context.Employees.ToList();
            return View("Index", employees);
        }
    }
}
