using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Airbag.Datos.DTO;
using Airbag.Datos;
using Airbag.Logica;

namespace Airbag.Admin.Models
{
    public class UsuarioViewModel
    {
        public UsuarioDTO usuarioDTO { get; set; }

        public List<UsuarioDTO> listaUsuarioDto { get; set; }

        public List<UsuarioDTO> CargarUsuarios()
        {
            LogicaUsuario oLogicaUsuario = new LogicaUsuario();

             listaUsuarioDto = oLogicaUsuario.ObtenerDatosUsuarios();

            return (listaUsuarioDto);
        }
    }
}