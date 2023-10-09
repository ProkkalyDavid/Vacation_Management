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
            return View();
        }

        [HttpGet]
        public IActionResult CreateLeaveRequest()
        {
            return View();
        }
    }
}
