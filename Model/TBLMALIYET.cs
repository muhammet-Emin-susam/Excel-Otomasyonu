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
    
    public partial class TBLMALIYET
    {
        public short ISLETME_KODU { get; set; }
        public string KOD { get; set; }
        public Nullable<decimal> HAMYUZ { get; set; }
        public Nullable<decimal> ISCYUZ { get; set; }
        public Nullable<decimal> ENERJIYUZ { get; set; }
        public Nullable<decimal> AMORYUZ { get; set; }
        public System.DateTime TARIH { get; set; }
        public Nullable<decimal> AMBYUZ { get; set; }
        public Nullable<decimal> YARDSERYUZ { get; set; }
        public Nullable<decimal> YEDEKPYUZ { get; set; }
        public Nullable<decimal> MALGIDER1_YUZ { get; set; }
        public Nullable<decimal> MALGIDER2_YUZ { get; set; }
        public Nullable<decimal> MALGIDER3_YUZ { get; set; }
        public Nullable<decimal> HAMORAN { get; set; }
        public Nullable<decimal> MALGIDER4_YUZ { get; set; }
        public Nullable<decimal> MALGIDER5_YUZ { get; set; }
        public Nullable<decimal> URETMIK { get; set; }
        public Nullable<decimal> MASRAFYUZ { get; set; }
        public Nullable<decimal> HAMMIK { get; set; }
        public Nullable<decimal> HAMSTUT { get; set; }
        public Nullable<decimal> ISCILIK { get; set; }
        public Nullable<decimal> ENERJI { get; set; }
        public Nullable<decimal> AMORTISMAN { get; set; }
        public Nullable<decimal> AMBALAJ { get; set; }
        public Nullable<decimal> YARDSER { get; set; }
        public Nullable<decimal> YEDEKP { get; set; }
        public Nullable<decimal> MALGIDER1 { get; set; }
        public Nullable<decimal> MALGIDER2 { get; set; }
        public Nullable<decimal> MALGIDER3 { get; set; }
        public Nullable<decimal> MALFIAT { get; set; }
        public Nullable<decimal> STOK_MIK { get; set; }
        public Nullable<decimal> SATIS_TUT { get; set; }
        public Nullable<decimal> SATIS_MIK { get; set; }
        public Nullable<decimal> ORTSFIAT { get; set; }
        public Nullable<decimal> ORTMAL { get; set; }
        public Nullable<decimal> IADETUT { get; set; }
        public Nullable<decimal> YARIMSARF { get; set; }
        public Nullable<decimal> ISCILIK2 { get; set; }
        public Nullable<decimal> MALGIDER4 { get; set; }
        public Nullable<decimal> MALGIDER5 { get; set; }
        public Nullable<decimal> IADEMIK { get; set; }
        public string ANAKOD { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<decimal> YEDEK3 { get; set; }
        public Nullable<decimal> YEDEK4 { get; set; }
        public Nullable<decimal> YEDEK5 { get; set; }
        public Nullable<decimal> YEDEK6 { get; set; }
        public Nullable<decimal> YEDEK7 { get; set; }
        public Nullable<decimal> YEDEK8 { get; set; }
        public string YEDEK9 { get; set; }
        public string YEDEK10 { get; set; }
        public Nullable<short> YEDEK11 { get; set; }
        public Nullable<short> YEDEK12 { get; set; }
        public Nullable<decimal> CURHAMSTUT { get; set; }
        public Nullable<decimal> CURISCILIK { get; set; }
        public Nullable<decimal> CURENERJI { get; set; }
        public Nullable<decimal> CURAMORTISMAN { get; set; }
        public Nullable<decimal> CURAMBALAJ { get; set; }
        public Nullable<decimal> CURYARDSER { get; set; }
        public Nullable<decimal> CURYEDEKP { get; set; }
        public Nullable<decimal> CURMALGIDER1 { get; set; }
        public Nullable<decimal> CURMALGIDER2 { get; set; }
        public Nullable<decimal> CURMALGIDER3 { get; set; }
        public Nullable<decimal> CURMALFIAT { get; set; }
        public Nullable<decimal> CURSATIS_TUT { get; set; }
        public Nullable<decimal> CURORTSFIAT { get; set; }
        public Nullable<decimal> CURORTMAL { get; set; }
        public Nullable<decimal> CURIADETUT { get; set; }
        public Nullable<decimal> CURYARIMSARF { get; set; }
        public Nullable<decimal> CURISCILIK2 { get; set; }
        public Nullable<decimal> CURMALGIDER4 { get; set; }
        public Nullable<decimal> CURMALGIDER5 { get; set; }
        public Nullable<decimal> CURHAMORAN { get; set; }
        public Nullable<decimal> EXPSATISTUT { get; set; }
        public Nullable<decimal> CUREXPSATISTUT { get; set; }
        public Nullable<decimal> EXPSATISMIK { get; set; }
        public Nullable<decimal> MALGIDER6 { get; set; }
        public Nullable<decimal> MALGIDER6_YUZ { get; set; }
        public Nullable<decimal> CURMALGIDER6 { get; set; }
        public Nullable<decimal> MALGIDER7 { get; set; }
        public Nullable<decimal> MALGIDER7_YUZ { get; set; }
        public Nullable<decimal> CURMALGIDER7 { get; set; }
        public Nullable<decimal> MALGIDER8 { get; set; }
        public Nullable<decimal> MALGIDER8_YUZ { get; set; }
        public Nullable<decimal> CURMALGIDER8 { get; set; }
        public Nullable<decimal> MALGIDER9 { get; set; }
        public Nullable<decimal> MALGIDER9_YUZ { get; set; }
        public Nullable<decimal> CURMALGIDER9 { get; set; }
        public Nullable<decimal> MALGIDER10 { get; set; }
        public Nullable<decimal> MALGIDER10_YUZ { get; set; }
        public Nullable<decimal> CURMALGIDER10 { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLMALIGRUP TBLMALIGRUP { get; set; }
    }
}
