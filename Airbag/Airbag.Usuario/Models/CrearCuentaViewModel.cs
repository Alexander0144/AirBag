using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Airbag.Logica;
using Airbag.Datos;

namespace Airbag.Usuario.Models
{
    public class CrearCuentaViewModel
    {
        //tblUsuario usuario { get; set; }
        public bool AgregarUsuario(tblUsuario usuario)
        {
            bool inserto = true;
            LogicaUsuario logica = new LogicaUsuario();
            inserto = logica.AgregarUsuario(usuario);
            return inserto;
        }
    }
}