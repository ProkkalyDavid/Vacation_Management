using Microsoft.AspNetCore.Mvc;
using Vacation_Management.Data;

namespace Vacation_Management.Controllers
{
    public class AdministratorController : Controller
    {
        IAdministartorRepository repository;

        public AdministratorController(IAdministartorRepository repository)
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

        [HttpGet]
        public IActionResult ReadRequests()
        {
            return View();//todo
        }

        [HttpPost]
        public IActionResult Decline()
        {
            //todo
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Accept()
        {
            //todo
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult DeleteCategory()
        {
            //todo
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult CreateCategory()
        {
            //todo
            return RedirectToAction("index");
        }

        //leave category change, user group category change
    }
}
