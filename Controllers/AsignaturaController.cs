using Microsoft.AspNetCore.Mvc;
using  asp.net_core_MVC.Models;
using System;
using System.Collections.Generic;

namespace asp.net_core_MVC.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index() 
        {
          
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas",
                                UniqueId= Guid.NewGuid().ToString()
                            } ,
                            new Asignatura{Nombre="Educación Física",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Castellano",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Ciencias Naturales",
                                UniqueId= Guid.NewGuid().ToString()
                            }
                            ,
                            new Asignatura{Nombre="Programación",
                                UniqueId= Guid.NewGuid().ToString()
                            }
                };
            ViewBag.OtrosDatos = "Otros";
            return View("MultiAsignatura",listaAsignaturas);
        
    }
}    
}