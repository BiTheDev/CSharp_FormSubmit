using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmit.Models;


namespace FormSubmit.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("index");
        }

        
        [HttpPost("Create")]
        public IActionResult Create(Form Register){
            if(ModelState.IsValid){
                return View("result", Register);
            }else{
                return View("index");
            }
        }
    }
}
