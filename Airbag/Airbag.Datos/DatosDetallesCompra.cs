using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    class DatosDetallesCompra
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblDetallesCompra> ObtenerDetallesCompras()
        {
            //implementar metodo que retorne lista con datos de los detalles de todas las compras
            return null;
        } 

        public void AgregarDetalleCompra(tblDetallesCompra detalleCompra)
        {
            //implementar metodo para agregar un nuevo detalle de compra a la BDD
        }
    }
}
