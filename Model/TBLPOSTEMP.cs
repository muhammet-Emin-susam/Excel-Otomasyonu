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
    
    public partial class TBLPOSTEMP
    {
        public short SUBE_KODU { get; set; }
        public string KAYIT_TIPI { get; set; }
        public string KOD { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string TIP { get; set; }
        public Nullable<short> LOCAL_DEPO { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public Nullable<decimal> BRUT_TUTAR { get; set; }
        public Nullable<decimal> ISKONTO { get; set; }
        public Nullable<byte> KDV { get; set; }
        public string PLASIYER { get; set; }
        public string YAPKOD { get; set; }
        public Nullable<int> STHARINCKEYNO { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public string KOLISTOK { get; set; }
    
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
