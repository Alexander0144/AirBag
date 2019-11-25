using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Airbag.Logica;
using Airbag.Datos;

namespace Airbag.Usuario.Models
{
    public class InicioSesionViewModel
    {
        tblUsuario usuario { get; set; }


        public void VerificarUsuario(string cCorreo, string cContrasenia)
        {
            LogicaUsuario Logica = new LogicaUsuario();
            string mensaje = Logica.VerificarUsuario(cCorreo, cContrasenia);
            usuario = HttpContext.Current.Session["usuario"] as tblUsuario;

        }
    }
}