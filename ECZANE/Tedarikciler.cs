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
    
    public partial class Tedarikciler
    {
        public int Tedarikci_ID { get; set; }
        public Nullable<int> İlac_ID { get; set; }
        public string Tedarikci_adı { get; set; }
        public string Tedarik_sehir { get; set; }
    
        public virtual İlac_cesit İlac_cesit { get; set; }
    }
}
