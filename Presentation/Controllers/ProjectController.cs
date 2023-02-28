
using AutoMapper;
using Credens.Infrastructure.DTO;
using Credens.Infrastructure.Interface;
using Credens.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Credens.Presentation.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IService<ProjectDTO> _service;
        private readonly IMapper _mapper;

        public ProjectController(IService<ProjectDTO> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var rez = _mapper.Map<IEnumerable<ProjectViewModel>> (await _service.GetListAsync());  
            return View(rez);
        }

        //[HttpGet]
        //public IActionResult GetById(int id)
        //{
        //    var project = _service.Get(x => x.ProjectId == id);
        //    return View(project);
        //}

        //[HttpGet]
        //public async Task<IActionResult> Index() 
        //{
        //    var rez = await _service.GetList();
            
        //     return View(rez.Data);
        //}

        //[HttpGet]
        //public IActionResult MyGetByName(string name)
        //{
        //    var rez = _service.GetAll().Data.Where(x => x.OrderName == name);

        //    return View(rez);
        //}



        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create([Bind("ProjectId, OrderValue, OrderMonth, OrderYear, CustomerId," +
        //    " OrderName, Price, City, ResidentialComplex, TypeStreet, Street, BuildingNumber, Litera, BuildingPart, " +
        //    "Apartment, Floor, ManagerId, MakerId, BranchId")]Project entity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _service.CreateAsync(entity);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(entity);
        //}

    }
}
