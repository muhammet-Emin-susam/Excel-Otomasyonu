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
    
    public partial class TBLBSENPAR
    {
        public short ISLETME_KODU { get; set; }
        public string SC_CARIDETAY { get; set; }
        public string SC_MUHDETAY { get; set; }
        public string SC_TAHTEMC_CARIDEN { get; set; }
        public string SC_VERENK_ARANSIN { get; set; }
        public string SC_VERILENK_ARANSIN { get; set; }
        public string SC_ALBOR_GCIK { get; set; }
        public string SC_VERBOR_GCIK { get; set; }
        public Nullable<short> S_PORAN { get; set; }
        public string IL { get; set; }
        public string SADECE_TL { get; set; }
        public string BORD_SAT { get; set; }
        public string KAYIT_TAR { get; set; }
        public Nullable<short> BORD_SAYUZ { get; set; }
        public string KARS_CEK { get; set; }
        public string BANKA_KOD { get; set; }
        public string MATBU_CEK { get; set; }
        public string BASIM_DIZAYN { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public string YEDEK3 { get; set; }
        public string YEDEK4 { get; set; }
        public string YEDEK5 { get; set; }
        public string YEDEK6 { get; set; }
        public string YEDEK7 { get; set; }
        public string YEDEK8 { get; set; }
        public string YEDEK9 { get; set; }
        public string YEDEK10 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
    }
}
