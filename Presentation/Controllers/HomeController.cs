using Credens.BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using Credens.DAL.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Credens.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<Project> _service;
        public HomeController(IService<Project> service)
        {

            _service = service;
        }

        public IActionResult Index()
        {
            Project qwerty = new Project();
            qwerty.Address = "ghjhjkghnm,fdtghethykfvntyjfgntynetyjfgnrtn";
            qwerty.Descr = "dsafsfgntynetyj rtuwrthy rtyjhwrtyh wrtyurtyhdg";
            _service.Add(qwerty);
            
            return View(qwerty);
        }
    }
}
