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
    
    public partial class TBLDAGPLASZIYARET
    {
        public short ISLETME_KODU { get; set; }
        public System.DateTime ZAMAN { get; set; }
        public string PLASIYERKOD { get; set; }
        public string CARIKOD { get; set; }
        public string BARKODOKUTTUMU { get; set; }
        public Nullable<int> NEDENKOD { get; set; }
        public string MNOT { get; set; }
        public string ZIYARETEDILDIMI { get; set; }
        public Nullable<System.DateTime> SAAT { get; set; }
        public int ZIYARETSIRA { get; set; }
        public int DAGITIMSIRA { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string ROTAKODU { get; set; }
        public string VASITANO { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
    }
}
