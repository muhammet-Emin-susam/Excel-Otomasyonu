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
    
    public partial class TBLNFDTRA
    {
        public int RECID { get; set; }
        public int MASID { get; set; }
        public string CNAME { get; set; }
        public string CTYPE { get; set; }
        public Nullable<byte> COLID { get; set; }
        public string CENABLE { get; set; }
        public string CVISIBLE { get; set; }
        public Nullable<int> CCOLOR { get; set; }
        public string CCAPTION { get; set; }
        public string CFORMAT { get; set; }
        public Nullable<byte> CONDALIK { get; set; }
        public Nullable<byte> CUZUNLUK { get; set; }
        public Nullable<byte> CGENISLIK { get; set; }
        public string CYEDEK1 { get; set; }
        public string CYEDEK2 { get; set; }
        public Nullable<short> IYEDEK1 { get; set; }
        public Nullable<short> IYEDEK2 { get; set; }
        public Nullable<int> IYEDEK3 { get; set; }
        public Nullable<decimal> FYEDEK1 { get; set; }
        public Nullable<System.DateTime> TYEDEK1 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
    
        public virtual TBLNFDMAS TBLNFDMAS { get; set; }
    }
}
