using Credens.BLL.DTO;
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
        public IActionResult GetById(int id)
        {
            var project = _service.Get(x => x.ProjectId == id);
            return View(project);
        }

        [HttpGet]
        public async Task<IActionResult> Index() 
        {
            var rez = await _service.GetList();
            
             return View(rez.Data);
        }

        [HttpGet]
        public IActionResult MyGetByName(string name)
        {
            var rez = _service.GetAll().Data.Where(x => x.OrderName == name);

            return View(rez);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProjectId, OrderValue, OrderMonth, OrderYear, CustomerId," +
            " OrderName, Price, City, ResidentialComplex, TypeStreet, Street, BuildingNumber, Litera, BuildingPart, " +
            "Apartment, Floor, ManagerId, MakerId, BranchId")]Project entity)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateAsync(entity);
                return RedirectToAction(nameof(Index));
            }
            return View(entity);
        }

    }
}
