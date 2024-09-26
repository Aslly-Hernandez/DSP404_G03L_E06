using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteWebApp.Models
{
    public class HistorialPedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Pedido Pedido { get; set; }
        public string ComentariosEmpleado { get; set; }
    }
}