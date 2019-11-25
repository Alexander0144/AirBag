using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Airbag.Datos;
using Airbag.Logica;

namespace Airbag.Usuario.Models
{
    public class ProductosEnCategoriaViewModel
    {
        public string nombreCategoria { get; set; }
        public List<tblCat_Categoria> categorias { get; set; }

        public List<tblCat_Producto> procutos { get; set; }

        public void CargarCategorias()
        {

        }

        public void CargarPoductosEnCategoria()
        {
            
        }

    }
}
