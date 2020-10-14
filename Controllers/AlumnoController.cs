using Microsoft.AspNetCore.Mvc;
using  asp.net_core_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace asp.net_core_MVC.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index() 
        {
          
          

        List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   Nombre = $"{n1} {n2} {a1}" ,
                                   UniqueId = Guid.NewGuid().ToString()
                                   };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
            var listaAlumnos = GenerarAlumnosAlAzar();

            ViewBag.OtrosDatos = "Otros";
            return View("MultiAlumno",listaAlumnos);
        
    }
}    
}