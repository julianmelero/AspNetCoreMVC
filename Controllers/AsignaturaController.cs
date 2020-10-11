using Microsoft.AspNetCore.Mvc;
using  asp.net_core_MVC.Models;
using System;

namespace asp.net_core_MVC.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index() 
        {
            var asignatura = new Asignatura{                        
            //asignatura.UniqueId = Guid.NewGuid().ToString(),
            Nombre = "Programación"
            };
            ViewBag.OtrosDatos = "Otros";

            return View(asignatura);
        }
    }
}