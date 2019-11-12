using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    class DatosCarrito
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblCat_Carrito> ObtenerDatosCarrito()
        {
            //implementar metodo que retorne lista con datos de los productos en carrito
            return null;
        }

        public void AgregarProductoAlCarrito(tblCat_Carrito carrito)
        {
            //Implementar metodo para registrar un nuevo producto en el carrito
        }
    }
}
