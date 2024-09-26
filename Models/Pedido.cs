using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteWebApp.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<Plato> Platos { get; set; } = new List<Plato>();
        public decimal Total { get; set; }
        public string Estado { get; set; }  // Ejemplo: "En preparación", "Entregado"
        public string Comentarios { get; set; }
        public string FormaPago { get; set; }  // Ejemplo: "Efectivo", "Tarjeta"
    }
}