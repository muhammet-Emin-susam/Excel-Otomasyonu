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
    
    public partial class TBLDAGZIYARETFREKANS
    {
        public short ISLETME_KODU { get; set; }
        public string CARIKOD { get; set; }
        public string PLASIYERKOD { get; set; }
        public string HAFTA1 { get; set; }
        public string HAFTA2 { get; set; }
        public string HAFTA3 { get; set; }
        public string HAFTA4 { get; set; }
        public string GUN1 { get; set; }
        public string GUN2 { get; set; }
        public string GUN3 { get; set; }
        public string GUN4 { get; set; }
        public string GUN5 { get; set; }
        public string GUN6 { get; set; }
        public string GUN7 { get; set; }
        public Nullable<int> ZIYARETSIRA { get; set; }
        public int ZIYARETSIRA1 { get; set; }
        public int ZIYARETSIRA2 { get; set; }
        public int ZIYARETSIRA3 { get; set; }
        public int ZIYARETSIRA4 { get; set; }
        public int ZIYARETSIRA5 { get; set; }
        public int ZIYARETSIRA6 { get; set; }
        public int ZIYARETSIRA7 { get; set; }
        public int DAGITIMSIRA1 { get; set; }
        public int DAGITIMSIRA2 { get; set; }
        public int DAGITIMSIRA3 { get; set; }
        public int DAGITIMSIRA4 { get; set; }
        public int DAGITIMSIRA5 { get; set; }
        public int DAGITIMSIRA6 { get; set; }
        public int DAGITIMSIRA7 { get; set; }
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
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
    }
}
