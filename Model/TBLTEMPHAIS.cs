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
    
    public partial class TBLTEMPHAIS
    {
        public short SUBE_KODU { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string ISEMRINO { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ISMI { get; set; }
        public string MAM_KODU { get; set; }
        public string MAM_ISMI { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public string PROJE_KODU { get; set; }
        public string SARFEDILEN_MAMUL { get; set; }
    
        public virtual TBLPROJE TBLPROJE { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
