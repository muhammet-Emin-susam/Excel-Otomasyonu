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
    
    public partial class TBLREPLANISH
    {
        public int INCKEYNO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public short SUBE_KODU { get; set; }
        public Nullable<short> DEPO_KODU { get; set; }
        public string SATICI_KODU { get; set; }
        public string STOK_KODU { get; set; }
        public Nullable<decimal> NETSIS_MIK { get; set; }
        public Nullable<decimal> SIP_MIK { get; set; }
        public Nullable<decimal> MAD { get; set; }
        public string ABC_KODU { get; set; }
        public Nullable<decimal> SOQ { get; set; }
        public Nullable<decimal> MUSBAK { get; set; }
        public Nullable<decimal> SATBAK { get; set; }
        public Nullable<decimal> STOKBAK { get; set; }
        public string SIPARIS_NO { get; set; }
        public string GRKOD { get; set; }
        public string KOD1 { get; set; }
        public string KOD2 { get; set; }
        public string FIATKOD { get; set; }
        public string PROJE_KODU { get; set; }
        public string YAPKOD { get; set; }
    
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
