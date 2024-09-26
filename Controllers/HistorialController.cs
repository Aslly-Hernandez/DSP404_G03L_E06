using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteWebApp.Models;

namespace RestauranteWebApp.Controllers
{
    public class HistorialController : Controller
    {
        // GET: Historial
        private static List<HistorialPedido> historialPedidos = new List<HistorialPedido>();

        public ActionResult VerHistorial()
        {
            return View(historialPedidos);
        }

        public ActionResult AgregarComentario(int pedidoId, string comentario)
        {
            var pedidoHistorial = historialPedidos.FirstOrDefault(h => h.Pedido.Id == pedidoId);
            if (pedidoHistorial != null)
            {
                pedidoHistorial.ComentariosEmpleado = comentario;
            }
            return RedirectToAction("VerHistorial");
        }
    }
}