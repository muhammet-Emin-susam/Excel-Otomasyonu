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
    
    public partial class TBLMAKMALIYET
    {
        public System.DateTime TARIH { get; set; }
        public short SUBE_KODU { get; set; }
        public int MAKINCKEYNO { get; set; }
        public int MSRINCKEYNO { get; set; }
        public decimal TUTAR { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string CYEDEK1 { get; set; }
        public string CYEDEK2 { get; set; }
        public Nullable<int> IYEDEK1 { get; set; }
        public Nullable<int> IYEDEK2 { get; set; }
        public Nullable<decimal> FYEDEK1 { get; set; }
        public Nullable<decimal> FYEDEK2 { get; set; }
        public Nullable<System.DateTime> DYEDEK1 { get; set; }
        public Nullable<System.DateTime> DYEDEK2 { get; set; }
        public string STRYEDEK1 { get; set; }
        public string STRYEDEK2 { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLMRPMAKINE TBLMRPMAKINE { get; set; }
        public virtual TBLMAKMSRMAS TBLMAKMSRMAS { get; set; }
    }
}
