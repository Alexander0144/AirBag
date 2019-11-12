using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    class DatosCompra
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblCompra> ObtenerDatosCompras()
        {
            //implementar método que retorne lista con datos de todas las compras Realizadas
            return null;
        }

        public void AgregarCompra(tblCompra compra)
        {
            //implementar metodo para registrar una nueva compra realizada en la bdd
        }
    }
}
