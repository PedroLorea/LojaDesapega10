using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDesapega10.Controllers
{
    public class HelloWorldController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name = "Usuário", int numTimes = 1)
        {
            ViewData["Message"] = "Bem-vindo " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

