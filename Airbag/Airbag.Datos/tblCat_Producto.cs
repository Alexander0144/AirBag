//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airbag.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCat_Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCat_Producto()
        {
            this.tblCat_Carrito = new HashSet<tblCat_Carrito>();
            this.tblDetallesCompra = new HashSet<tblDetallesCompra>();
        }
    
        public int iIdProducto { get; set; }
        public int iIdCategoria { get; set; }
        public bool iEstatus { get; set; }
        public int iExistencia { get; set; }
        public int iCantidadVendida { get; set; }
        public decimal dPrecio { get; set; }
        public string cNombre { get; set; }
        public string cDescripcion { get; set; }
        public string cRutalmgProducto { get; set; }
        public System.DateTime dtFechaRegistro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCat_Carrito> tblCat_Carrito { get; set; }
        public virtual tblCat_Categoria tblCat_Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDetallesCompra> tblDetallesCompra { get; set; }
    }
}
