//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECZANE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hastalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hastalar()
        {
            this.Fatura = new HashSet<Fatura>();
        }
    
        public int Hasta_ID { get; set; }
        public string Hasta_tc { get; set; }
        public string Hasta_Adı { get; set; }
        public string Hasta_Soyadı { get; set; }
        public string Hasta_İlaç { get; set; }
        public string Hasta_yas { get; set; }
        public Nullable<int> Doktor_ID { get; set; }
        public Nullable<int> Hastane_ID { get; set; }
    
        public virtual  Doktorlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Fatura { get; set; }
        public virtual Hastaneler Hastaneler { get; set; }
    }
}