using Microsoft.AspNetCore.Mvc;
using Vacation_Management.Data;

namespace Vacation_Management.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CalendarView()
        {
            //todo
            return View();
        }

        [HttpPost]
        public IActionResult CreateLeaveRequest()
        {
            //todo
            return RedirectToAction("Index");
        }
    }
}
