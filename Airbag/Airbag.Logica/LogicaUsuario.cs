using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Airbag.Datos;
using Airbag.Datos.DTO;

namespace Airbag.Logica
{
    public class LogicaUsuario
    {
        /// <summary>
        /// Método que obtiene los datos registrados del usuario.
        /// </summary>
        /// <returns>Devuelve la lista de los datos obtenidos del usuario</returns>
        public List<UsuarioDTO> ObtenerDatosUsuarios()
        {
            AirbagEntities contexto = new AirbagEntities();

            contexto.Configuration.LazyLoadingEnabled = false;
            contexto.Configuration.ProxyCreationEnabled = false;

            List<UsuarioDTO> lstUsuarios = (from obtener in contexto.tblUsuario.AsNoTracking()
                                            select (new UsuarioDTO
                                            {
                                                iIdUsuario = obtener.iIdUsuario,
                                                cNombre = obtener.cNombre,
                                                cApellidoPaterno = obtener.cApellidoPaterno,
                                                cApellidoMaterno = obtener.cApellidoMaterno,
                                                cCorreo = obtener.cCorreo,
                                                iEstatus = obtener.iEstatus.Value

                                            })).ToList();
            return lstUsuarios;
        }

        /// <summary>
        /// Método para cambiar estatus del usuario, mediante el identificador y el estatus.
        /// </summary>
        /// <param name="iId">Tipo entero que identifica el usuario.</param>
        /// <param name="iEstatus">Tipo entero que tiene el valor del estatus del usuario.</param>
        /// <returns>Devuelve el objeto usuario.</returns>
        public UsuarioDTO CambiarEstatusdeUsuario(int iId, int iEstatus)
        {
            AirbagEntities contexto = new AirbagEntities();

            tblUsuario usuario = contexto.tblUsuario.AsNoTracking().FirstOrDefault(u => u.iIdUsuario == iId);



            usuario.iEstatus = iEstatus;

            contexto.Entry(usuario).State = EntityState.Modified;

            contexto.SaveChanges();

            UsuarioDTO oUsuario = new UsuarioDTO
            {
                iIdUsuario = usuario.iIdUsuario,
                cNombre = usuario.cNombre,
                cApellidoPaterno = usuario.cApellidoPaterno,
                cApellidoMaterno = usuario.cApellidoMaterno,
                cCorreo = usuario.cCorreo,
                iEstatus = usuario.iEstatus.Value
            };
            return oUsuario;
        }

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
                if (Usuario.cContrasenia == LogicaUsuario.EncriptarContraseñaUsuario(cContrasenia))
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
