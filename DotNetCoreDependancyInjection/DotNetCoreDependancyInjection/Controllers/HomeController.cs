using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreDependancyInjection.Models;
using DotNetCoreDependancyInjection.Repositories;

namespace DotNetCoreDependancyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IStudent _studentRepository;

        public HomeController(IStudent studentRepository)
        {
            _studentRepository = studentRepository;

        }
        public IActionResult Index()
        {
            var list=   _studentRepository.GetStudentList();
            return View(list);

        }

    }
}
