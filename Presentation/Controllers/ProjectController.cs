using Credens.BLL.Interface;
using Credens.DAL.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Credens.Presentation.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IService<Project> _service;

        public IActionResult MyGet()
        {
            return View();
        }
    }
}
