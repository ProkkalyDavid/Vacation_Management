using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using Vacation_Management.Data;

namespace Vacation_Management.Controllers
{
    public class ViewerController : Controller
    {
        IViewerRepository repository;
        public ViewerController(IViewerRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(this.repository.Read());
        }

        [HttpGet]
        public IActionResult CalendarView()
        {
            //todo
            return View();
        }
    }
}
