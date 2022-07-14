using Microsoft.AspNetCore.Mvc;
using pruebaEquirent.Datos;
using pruebaEquirent.Models;
using System.Collections;
using System.Collections.Generic;

namespace pruebaEquirent.Controllers
{
    public class ContactoController : Controller
    {
        private classFunciones Datos = new classFunciones();
        public IActionResult Index()
        {
            IEnumerable<Contacto> lista = Datos.Consultar();
            return View(lista);
        }
        public IActionResult BuscarId()
        {
            return View();
        }

      
        public IActionResult VistaId(int Id)
        {
            Contacto contacto = Datos.ConsultarId(Id);
            return View(contacto);
        }
    }
}
