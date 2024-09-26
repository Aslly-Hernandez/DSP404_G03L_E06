using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteWebApp.Models;

namespace RestauranteWebApp.Controllers
{
    public class PlatosController : Controller
    {
        // GET: Platos
        public ActionResult Menu()
        {
            List<Plato> platos = new List<Plato>
        {
            new Plato { Id = 1, Nombre = "Pizza", Precio = 10.50m, Descripcion = "Pizza con extra queso" },
            new Plato { Id = 2, Nombre = "Hamburguesa", Precio = 8.00m, Descripcion = "Hamburguesa con papas fritas" },
            new Plato { Id = 3, Nombre = "Lasana", Precio = 20.00m, Descripcion = "Lasana de pollo con arroz"},
            new Plato { Id = 4, Nombre = "Pasta", Precio = 10.20m, Descripcion = "Pasta con trozos de pollo"},
            new Plato { Id = 5, Nombre = "Alitas", Precio = 15.90m, Descripcion = "Alitas picantes o sencillas"},

        };

            return View(platos);
        }
       
    }
}