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
    
    public partial class DT_Telefone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DT_Telefone()
        {
            this.DT_Pessoa = new HashSet<DT_Pessoa>();
        }
    
        public int ID { get; set; }
        public int NUMERO { get; set; }
        public int DDD { get; set; }
        public int TIPO { get; set; }
    
        public virtual DT_Telefone_Tipo DT_Telefone_Tipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DT_Pessoa> DT_Pessoa { get; set; }
    }
}
