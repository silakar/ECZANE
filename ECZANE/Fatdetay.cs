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
    
    public partial class Fatdetay
    {
        public int Det_ID { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<int> Toplam { get; set; }
        public Nullable<int> FatID { get; set; }
        public Nullable<int> İlac_ID { get; set; }
        public Nullable<int> Stok_ilac_ID { get; set; }
    
        public virtual Fatura Fatura { get; set; }
        public virtual İlac_cesit İlac_cesit { get; set; }
        public virtual Stoktaki_ilaclar Stoktaki_ilaclar { get; set; }
    }
}