//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcellResim.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSIP12TOP
    {
        public short SUBE_KODU { get; set; }
        public string STOK_KODU { get; set; }
        public Nullable<decimal> MIKTAR_1 { get; set; }
        public Nullable<decimal> MIKTAR_2 { get; set; }
        public Nullable<decimal> MIKTAR_3 { get; set; }
        public Nullable<decimal> MIKTAR_4 { get; set; }
        public Nullable<decimal> MIKTAR_5 { get; set; }
        public Nullable<decimal> MIKTAR_6 { get; set; }
        public Nullable<decimal> MIKTAR_7 { get; set; }
        public Nullable<decimal> MIKTAR_8 { get; set; }
        public Nullable<decimal> MIKTAR_9 { get; set; }
        public Nullable<decimal> MIKTAR_10 { get; set; }
        public Nullable<decimal> MIKTAR_11 { get; set; }
        public Nullable<decimal> MIKTAR_12 { get; set; }
        public string YAPKOD { get; set; }
    
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
