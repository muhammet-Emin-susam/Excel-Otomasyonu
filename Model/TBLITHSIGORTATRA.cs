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
    
    public partial class TBLITHSIGORTATRA
    {
        public string DOSYANO { get; set; }
        public string FATIRS_NO { get; set; }
        public string CARI_KOD { get; set; }
        public string FTIRSIP { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<short> DOVIZ_TIPI { get; set; }
        public Nullable<decimal> DOV_TUT { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<decimal> BEYAN_DOV_TUT { get; set; }
        public Nullable<decimal> BEYAN_TUTAR { get; set; }
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
    
        public virtual TBLITHDOSYAMAS TBLITHDOSYAMAS { get; set; }
    }
}