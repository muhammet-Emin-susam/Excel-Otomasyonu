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
    
    public partial class TBLMUSTPRMEK
    {
        public short SUBE_KODU { get; set; }
        public short KESINTI_TIPI { get; set; }
        public Nullable<decimal> ALT_DEGER { get; set; }
        public Nullable<decimal> UST_DEGER { get; set; }
        public short ORAN_TIPI { get; set; }
        public Nullable<decimal> ORAN_DEGER { get; set; }
        public short SIRA { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
