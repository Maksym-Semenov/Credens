using Credens.BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using Credens.DAL.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Credens.Presentation.Controllers
{
    public class UserController : Controller
    {
        private readonly IService<User> _service;
        public UserController(IService<User> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            User qwerty = new User();
            _service.Add(qwerty);
            
            return View();
        }
    }
}
