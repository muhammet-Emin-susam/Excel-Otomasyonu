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
    
    public partial class TBLIHRNAKLIYETRA
    {
        public string DOSYANO { get; set; }
        public string FATIRS_NO { get; set; }
        public string CARI_KOD { get; set; }
        public string FTIRSIP { get; set; }
        public string ACENTA_KODU { get; set; }
        public string TASIYICI_KODU { get; set; }
        public string TEMSILCI_KODU { get; set; }
        public string SIGORTACI_KODU { get; set; }
        public string GOZLEMCI_KODU { get; set; }
        public string SEVK_YERI { get; set; }
        public Nullable<System.DateTime> SEVK_TARIHI { get; set; }
        public string YUKLEME_YERI { get; set; }
        public Nullable<System.DateTime> YUKLEME_TARIHI { get; set; }
        public string TRANSFER_YERI { get; set; }
        public Nullable<System.DateTime> TRANSFER_TARIHI { get; set; }
        public Nullable<System.DateTime> VARIS_TARIHI { get; set; }
        public Nullable<System.DateTime> BOSLATMA_TARIHI { get; set; }
        public string ARAC_ISMI { get; set; }
        public string BAYRAK { get; set; }
        public string SEFERNO { get; set; }
        public string NAKLIYETIPI { get; set; }
        public string VARIS_YERI { get; set; }
        public string VARIS_LIMAN { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<short> DOVIZ_TIPI { get; set; }
        public Nullable<decimal> DOV_TUT { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<short> BEYAN_DOVIZ_TIPI { get; set; }
        public Nullable<decimal> BEYAN_DOV_TUT { get; set; }
        public Nullable<decimal> BEYAN_TUTAR { get; set; }
        public string GOZLEMNO { get; set; }
        public string GUMRUK_KODU { get; set; }
        public string ACIKLAMA { get; set; }
        public string KONTEYNERTIP1 { get; set; }
        public string KONTEYNERTIP2 { get; set; }
        public string KONTEYNERTIP3 { get; set; }
        public string KONTEYNERTIP4 { get; set; }
        public string KONTEYNERTIP5 { get; set; }
        public Nullable<int> KONTEYNERADET1 { get; set; }
        public Nullable<int> KONTEYNERADET2 { get; set; }
        public Nullable<int> KONTEYNERADET3 { get; set; }
        public Nullable<int> KONTEYNERADET4 { get; set; }
        public Nullable<int> KONTEYNERADET5 { get; set; }
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
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLCASABIT TBLCASABIT1 { get; set; }
        public virtual TBLCASABIT TBLCASABIT2 { get; set; }
        public virtual TBLCASABIT TBLCASABIT3 { get; set; }
        public virtual TBLCASABIT TBLCASABIT4 { get; set; }
        public virtual TBLIHRDOSYAMAS TBLIHRDOSYAMAS { get; set; }
        public virtual TBLIHRGUMRUKMAS TBLIHRGUMRUKMAS { get; set; }
    }
}