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
    
    public partial class TBLBKMSBSTOK
    {
        public int INCKEYNO { get; set; }
        public short REFTIP { get; set; }
        public int REFINCKEYNO { get; set; }
        public string SIRANO { get; set; }
        public string STOKKODU { get; set; }
        public decimal MIKTAR { get; set; }
        public decimal BIRIMFIYAT { get; set; }
        public short HAREKETTIPI { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string CYEDEK1 { get; set; }
        public string CYEDEK2 { get; set; }
        public Nullable<int> IYEDEK1 { get; set; }
        public Nullable<int> IYEDEK2 { get; set; }
        public Nullable<int> IYEDEK3 { get; set; }
        public Nullable<int> IYEDEK4 { get; set; }
        public Nullable<decimal> FYEDEK1 { get; set; }
        public Nullable<decimal> FYEDEK2 { get; set; }
        public Nullable<decimal> FYEDEK3 { get; set; }
        public Nullable<decimal> FYEDEK4 { get; set; }
        public Nullable<System.DateTime> DYEDEK1 { get; set; }
        public Nullable<System.DateTime> DYEDEK2 { get; set; }
        public Nullable<System.DateTime> DYEDEK3 { get; set; }
        public Nullable<System.DateTime> DYEDEK4 { get; set; }
        public byte DURUMU { get; set; }
        public string BELGENO { get; set; }
    
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
    }
}