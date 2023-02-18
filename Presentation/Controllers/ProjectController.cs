using Credens.BLL.Interface;
using Credens.DAL.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Credens.Presentation.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IService<Project> _service;

        public ProjectController(IService<Project> service)
        {
            _service = service;
        }

        public IActionResult MyGet()
        {
            var a = _service.MyGet();
            return View(a);
        }
    }
}
