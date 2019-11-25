using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airbag.Datos;
using System.Web;
using System.Security.Cryptography;

namespace Airbag.Logica
{
    public class LogicaUsuario
    {
        public string VerificarUsuario(string cCorreo, string cContrasenia)
        {
            var ListaUsuarios = new DatosUsuario().ObtenerDatosUsuarios();
            tblUsuario Usuario = new tblUsuario();
            Usuario = ListaUsuarios.FirstOrDefault(u => u.cCorreo.Equals(cCorreo));
            string Mensaje = "";
            if (Usuario == null)
            {
                Mensaje = "correo invalido";
            }
            else
            {
                if(Usuario.cContrasenia == LogicaUsuario.EncriptarContraseñaUsuario(cContrasenia))
                {
                    HttpContext httpContext = HttpContext.Current;
                    httpContext.Session["usuario"] = Usuario;
                    Mensaje = "exito";
                }
                else
                {
                    Mensaje = "contraseña incorrecta";
                }
            }
            return Mensaje;
        }

        public static void CerrarSesion()
        {
            HttpContext.Current.Session["usuario"] = null;
        }

        public bool AgregarUsuario(tblUsuario usuario)
        {
            DatosUsuario datosUsuario = new DatosUsuario();
            return datosUsuario.AgregarUsuario(usuario);
        }

        public static string EncriptarContraseñaUsuario(string cContrasenia)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var contraseñaEncriptadaSHA1 = sha1.ComputeHash(Encoding.UTF8.GetBytes(cContrasenia));
                return string.Concat(contraseñaEncriptadaSHA1.Select(b => b.ToString("X2")));
            }
        }

        public static bool ExisteCorreo(string cCorreo)
        {
            DatosUsuario datosUsuario = new DatosUsuario();

            return datosUsuario.ExisteCorreoEnBDD(cCorreo);
        }

    }
}
