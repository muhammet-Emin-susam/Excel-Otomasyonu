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
    
    public partial class TBLKKGRPARALIK
    {
        public int INCKEYNO { get; set; }
        public string GRPKOD { get; set; }
        public string MYNKOD { get; set; }
        public decimal MIKTAR { get; set; }
        public decimal KKORAN { get; set; }
        public decimal YENIORNEKLEMMIK { get; set; }
        public decimal SABITMIKTAR { get; set; }
        public Nullable<decimal> KABULEDILEBILIRREDMIK { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string MIKTARKOD { get; set; }
        public string SEVIYE { get; set; }
        public Nullable<decimal> BITMIKTAR { get; set; }
        public Nullable<decimal> REDMIK { get; set; }
    
        public virtual TBLKKMYNTIP TBLKKMYNTIP { get; set; }
        public virtual TBLKKMIKTARKOD TBLKKMIKTARKOD { get; set; }
    }
}
