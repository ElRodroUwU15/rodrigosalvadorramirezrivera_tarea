//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppVenta.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente()
        {
            this.tb_venta = new HashSet<tb_venta>();
        }
    
        public int iDCliente { get; set; }
        public string nombreCliente { get; set; }
        public string direccionCliente { get; set; }
        public string duiCliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_venta> tb_venta { get; set; }
    }
}
