using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    public class DatosProducto
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblCat_Producto> ObtenerDatosProductos()
        {
            //implementar método que retorne lista con datos de todos los productos registrados
            return null;
        }

        public void AgregarProducto(tblCat_Producto producto)
        {
            //implementar método para registrar un nuevo producto en la base de datos
        }
    }
}
