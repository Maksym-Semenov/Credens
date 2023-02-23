using Credens.BLL.Interface;
using Credens.DAL.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var rez = _service.GetAll().Data.Where(x => x.Id == id);
            return View(rez);
        }

        [HttpGet]
        public async Task<IActionResult> MyGet2() 
        { 
             var  rez = await _service.GetList();
            
             return View(rez);
        }

        [HttpGet]
        public IActionResult MyGetByName(string name)
        {
            var rez = _service.GetAll().Data.Where(x => x.Name == name);

            return View(rez);
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Create ([Bind("Id, OrderNum, Name, Price, Descr, Adress, Fio, Phone, Phone2, Email, FioDesigner, " +
            "FioMaker, IsCompleted")]Project entity)
        {
            if(ModelState.IsValid)
            {
                await _service.CreateAsync(entity);
                return RedirectToAction(nameof(Index));
            }
            return View(entity);
        }

    }
}
