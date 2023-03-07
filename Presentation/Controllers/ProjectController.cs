
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Credens.Infrastructure.AutoMapper;
using Credens.Infrastructure.DTO;
using Credens.Infrastructure.Interface;
using Credens.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Credens.Presentation.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IService<ProjectDTO> _service;
        private readonly IMapper _mapper;
        private readonly IMapper _mapper2;

        public ProjectController(IService<ProjectDTO> service)
        {
            _service = service;
            _mapper = CredensMapper<ProjectDTO, ProjectViewModel>.MapperInit();
            _mapper2 = CredensMapper<ProjectViewModel, ProjectDTO>.MapperInit();
        }

        [HttpGet]
        public  IActionResult Index1()
        {
            var rez = _service.GetAll().ProjectTo<ProjectViewModel>(_mapper.ConfigurationProvider);
            
            return View(rez);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var rez = _mapper.Map<IEnumerable<ProjectViewModel>>(await _service.GetListAsync());

            return View(rez);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Create([Bind("OrderName, Price")]ProjectViewModel entity)
        {
            if (ModelState.IsValid)
            {
                var _entity = _mapper2.Map<ProjectDTO>(entity);
                 //_service.CreateAsync(_entity);
                _service.Create(_entity);
                return RedirectToAction(nameof(Index));
            }
            return View(entity);
        }

        
        [HttpGet]
        // GET: 
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return Problem(nameof(Index));
            }
            ProjectDTO projectDTO = _service.GetAll().Where(x => x.ProjectId == id).FirstOrDefault();
            if (projectDTO == null)
            {
                return Problem(nameof(Index));
            }
            return View(projectDTO);
        }

        // POST:
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectDTO project = _service.GetAll().Where(x => x.ProjectId == id).FirstOrDefault();
            _service.Delete(project);
            
            return RedirectToAction("Index");
        }


    }
}
