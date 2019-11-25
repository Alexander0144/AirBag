using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
                                                iEstatus = obtener.iEstatus

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
                iEstatus = usuario.iEstatus
            };
            return oUsuario;
        }
    }
}
