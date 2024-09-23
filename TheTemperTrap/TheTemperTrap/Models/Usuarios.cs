using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;



namespace TheTemperTrap.Models
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public string Nombres { get; set; }

        public int Correo { get; set; }
        public int Contra { get; set; }
        public int Direccion { get; set; }
        public string Telefono{ get; set; }
        public int idTipoUsuario { get; set; }


    }
}