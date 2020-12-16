using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica3.Models;
using Practica3.Data;

namespace busco.Controllers
{
    public class HomeController : Controller
    {
        private readonly RegistroContext _context;

        public HomeController(RegistroContext context)
        {
            _context = context;
        }
        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult Index()
        {
            var registros = _context.Registros.Where(x => x.NombreUsuario != null).ToList();

            return View(registros);
        }

        [HttpPost]
        public IActionResult Registro(Registro c)
        {
            if (ModelState.IsValid) {

                _context.Add(c);
                _context.SaveChanges();

             
                return RedirectToAction("Index");
            }

            return View(c);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

