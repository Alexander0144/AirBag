//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airbag.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTarjeta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTarjeta()
        {
            this.tblCompra = new HashSet<tblCompra>();
        }
    
        public int iIdTarjeta { get; set; }
        public Nullable<int> iIdUsuario { get; set; }
        public int iMesVencimiento { get; set; }
        public int iAnioVencimiento { get; set; }
        public string cNumeroTarjeta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompra> tblCompra { get; set; }
        public virtual tblUsuario tblUsuario { get; set; }
    }
}