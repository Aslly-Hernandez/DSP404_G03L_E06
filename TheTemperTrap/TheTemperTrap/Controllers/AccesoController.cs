using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheTemperTrap.Models;
using System.Data.SqlClient;
using System.Data;
using System.Web.Services.Description;


namespace TheTemperTrap.Controllers
{
    public class AccesoController : Controller
    {
        static string cadenaConexion = @"Data source=DESKTOP-A9EINB3;Initial Catalog=TheTemperTrapBD;Integrated Security=True";
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Usuarios usuarios)
        {
            bool Registrado;
            string Mensaje;

            if (usuarios.Contra == usuarios.Contra)
            {

            }
            else
            {
                return View();
            }

            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                SqlCommand cd = new SqlCommand("sp_RegistrarUsuario", cn);
                cd.Parameters.AddWithValue("Nombres", usuarios.Nombres);
                cd.Parameters.AddWithValue("Correo", usuarios.Correo);
                cd.Parameters.AddWithValue("Contraseña", usuarios.Contra);
                cd.Parameters.AddWithValue("Direccion", usuarios.Direccion);
                cd.Parameters.AddWithValue("Telefono", usuarios.Telefono);
                cd.Parameters.Add("Registrado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cd.Parameters.Add("Mensaje", SqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                cd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                cd.ExecuteNonQuery();

                Registrado = Convert.ToBoolean(cd.Parameters["Registrado"].Value);
                Mensaje = cd.Parameters["Mensaje"].Value.ToString();
            }
            ViewData["Mensaje"] = Mensaje;

            if (Registrado)
            {
                return RedirectToAction("Login", "Acceso");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Login(Usuarios usuarios)
        {
            usuarios.Contra = usuarios.Contra;

            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                SqlCommand cd = new SqlCommand("sp_ValidarUsuario", cn);
                cd.Parameters.AddWithValue("Nombres", usuarios.Nombres);
                cd.Parameters.AddWithValue("Correo", usuarios.Correo);
                cd.Parameters.AddWithValue("Contra", usuarios.Contra);
                cd.Parameters.AddWithValue("Direccion", usuarios.Direccion);
                cd.Parameters.AddWithValue("Telefono", usuarios.Telefono);
                cd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                usuarios.idUsuario = Convert.ToInt32(cd.ExecuteScalar().ToString());

            }

            if(usuarios.idUsuario != 0)
            {
                Session["usuario"] = usuarios;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Mensaje"] = "Usuario no encontrado";
                return View();
            }
            

        }

    }
}
