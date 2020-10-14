using Microsoft.AspNetCore.Mvc;
using  asp.net_core_MVC.Models;
using System;
using System.Linq;

namespace asp.net_core_MVC.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
       
        public IActionResult Index() 
        {
            // var escuela = new Escuela();                        
            // escuela.AñoDeCreación = 2005;
            // escuela.UniqueId = Guid.NewGuid().ToString();
            // escuela.Nombre = "Julián's SChool";
            // escuela.Ciudad= "València";
            // escuela.Pais= "España";
            // escuela.Dirección = "C/ Sin número";

            ViewBag.OtrosDatos = "Otros";
            var escuela = _context.Escuelas.FirstOrDefault();

            return View(escuela);
        }      
         public EscuelaController(EscuelaContext context) 
        {            
            _context = context;
        }
    }
}