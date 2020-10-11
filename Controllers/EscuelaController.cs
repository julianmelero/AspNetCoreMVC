using Microsoft.AspNetCore.Mvc;
using  asp.net_core_MVC.Models;
using System;

namespace asp.net_core_MVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index() 
        {
            var escuela = new Escuela();                        
            escuela.añoFundación = 2005;
            escuela.EscuelaID = Guid.NewGuid().ToString();
            escuela.Nombre = "Julián's SChool";


            return View(escuela);
        }
    }
}