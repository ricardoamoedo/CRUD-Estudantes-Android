//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNIP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DT_Telefone_Tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DT_Telefone_Tipo()
        {
            this.DT_Telefone = new HashSet<DT_Telefone>();
        }
    
        public int ID { get; set; }
        public string TIPO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DT_Telefone> DT_Telefone { get; set; }
    }
}