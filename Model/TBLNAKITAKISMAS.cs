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
    
    public partial class TBLNAKITAKISMAS
    {
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public string RAPORNO { get; set; }
        public string ACIKLAMA { get; set; }
        public int DONEMTIPI { get; set; }
        public System.DateTime BASTAR { get; set; }
        public int DONEM_UZUNLUK { get; set; }
        public int DOVIZ_CEVRIM_TIPI { get; set; }
        public string SUBELER_DAHIL { get; set; }
        public string BELGE_TIP1 { get; set; }
        public string BELGE_TIP2 { get; set; }
        public string BELGE_TIP3 { get; set; }
        public string BELGE_TIP4 { get; set; }
        public string BELGE_TIP5 { get; set; }
        public string BELGE_TIP6 { get; set; }
        public string BELGE_TIP7 { get; set; }
        public string BELGE_TIP8 { get; set; }
        public string BELGE_TIP9 { get; set; }
        public string BELGE_TIP10 { get; set; }
        public string BELGE_TIP11 { get; set; }
        public string BELGE_TIP12 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<int> I_YEDEK5 { get; set; }
        public Nullable<int> I_YEDEK6 { get; set; }
        public Nullable<decimal> F_YEDEK5 { get; set; }
        public Nullable<decimal> F_YEDEK7 { get; set; }
        public Nullable<decimal> F_YEDEK8 { get; set; }
        public Nullable<decimal> F_YEDEK6 { get; set; }
        public Nullable<System.DateTime> D_YEDEK7 { get; set; }
        public Nullable<System.DateTime> D_YEDEK8 { get; set; }
        public Nullable<System.DateTime> D_YEDEK9 { get; set; }
        public Nullable<System.DateTime> D_YEDEK10 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}