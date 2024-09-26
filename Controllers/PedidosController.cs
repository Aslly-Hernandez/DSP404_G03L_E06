using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteWebApp.Models;

namespace RestauranteWebApp.Controllers
{
    public class PedidosController : Controller
    {

        // GET: Pedidos
        private static List<Pedido> pedidos = new List<Pedido>();

        // Mostrar pantalla de platos seleccionados
        public ActionResult SeleccionarPlatos(List<int> platoIds)
        {
            // Aquí recuperarías los platos seleccionados por el cliente y crearías el pedido
            List<Plato> platosSeleccionados = ObtenerPlatosPorIds(platoIds);
            Pedido nuevoPedido = new Pedido
            {
                Id = pedidos.Count + 1,
                Platos = platosSeleccionados,
                Total = platosSeleccionados.Sum(p => p.Precio),
                Estado = "En preparación",
                Comentarios = ""
            };

            pedidos.Add(nuevoPedido);
            return View(nuevoPedido);
        }

        public ActionResult FinalizarPago(int pedidoId, string formaPago)
        {
            var pedido = pedidos.FirstOrDefault(p => p.Id == pedidoId);
            if (pedido != null)
            {
                pedido.FormaPago = formaPago;
                pedido.Estado = "Pagado";
            }
            return View(pedido);
        }

        // Obtener platos por ids
        private List<Plato> ObtenerPlatosPorIds(List<int> platoIds)
        {
            // Simular obtención de platos de una base de datos
            List<Plato> platosDisponibles = new List<Plato>
        {
            new Plato { Id = 1, Nombre = "Pizza", Precio = 10.50m },
            new Plato { Id = 2, Nombre = "Hamburguesa", Precio = 8.00m },
            new Plato { Id = 1, Nombre = "Pizza", Precio = 10.50m, Descripcion = "Pizza con extra queso" },
            new Plato { Id = 2, Nombre = "Hamburguesa", Precio = 8.00m, Descripcion = "Hamburguesa con papas fritas" },
            new Plato { Id = 3, Nombre = "Lasana", Precio = 20.00m, Descripcion = "Lasana de pollo con arroz"},
            new Plato { Id = 4, Nombre = "Pasta", Precio = 10.20m, Descripcion = "Pasta con trozos de pollo"},
            new Plato { Id = 5, Nombre = "Alitas", Precio = 15.90m, Descripcion = "Alitas picantes o sencillas"},
        };

            return platosDisponibles.Where(p => platoIds.Contains(p.Id)).ToList();
        }

    }
}