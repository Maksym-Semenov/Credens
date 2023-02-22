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

        [HttpGet]
        public IActionResult MyGet(int id)
        {
            var rez = _service.GetAll();
           var a = rez.Data.Where(x => x.Id == id);
            return View(a);
        }

        [HttpGet]
        public async Task<IActionResult> MyGet2() 
        { 
             var  rez = await _service.GetList();
            
             return View(rez);
        }

    }
}
