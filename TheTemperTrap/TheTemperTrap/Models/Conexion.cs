using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace TheTemperTrap.Models
{
    public class Conexion
    {
        private string cadenaConexion { get; set; }

        private SqlConnection conexionSQL;
        public Conexion()
        {
            cadenaConexion = @"Data source=(local);Initial Catalog=Bolsa_Trabajo;Integrated Security=True";
        }

        public bool Conectar()
        {
            try
            {
                this.conexionSQL = new SqlConnection(this.cadenaConexion);
                this.conexionSQL.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool estadoConexion()
        {
            switch (this.conexionSQL.State)
            {
                case System.Data.ConnectionState.Broken:
                    return true;
                case System.Data.ConnectionState.Open:
                    return true;
                default:
                    return false;
            }
        }
        public void Desconectar()
        {
            this.conexionSQL.Close(); 
        }
    }


    }