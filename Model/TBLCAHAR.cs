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
    
    public partial class TBLCAHAR
    {
        public short SUBE_KODU { get; set; }
        public string CARI_KOD { get; set; }
        public System.DateTime TARIH { get; set; }
        public Nullable<System.DateTime> VADE_TARIHI { get; set; }
        public string BELGE_NO { get; set; }
        public string ACIKLAMA { get; set; }
        public string HKA { get; set; }
        public Nullable<decimal> BORC { get; set; }
        public Nullable<decimal> ALACAK { get; set; }
        public Nullable<decimal> BAKIYE { get; set; }
        public Nullable<byte> DOVIZ_TURU { get; set; }
        public Nullable<decimal> DOVIZ_TUTAR { get; set; }
        public string RAPOR_KODU { get; set; }
        public string F9SC { get; set; }
        public string HAREKET_TURU { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public string ILAVE_RAPOR_KODU { get; set; }
        public string UPDATE_KODU { get; set; }
        public Nullable<decimal> KAPATILMIS_TUTAR { get; set; }
        public Nullable<short> ODEME_GUNU { get; set; }
        public Nullable<byte> FIRMA_DOVIZ_TIPI { get; set; }
        public Nullable<decimal> FIRMA_DOVIZ_TUTARI { get; set; }
        public string PLASIYER_KODU { get; set; }
        public string ENT_REF_KEY { get; set; }
        public int INC_KEY_NUMBER { get; set; }
        public string RAPOR_KODU2 { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<byte> B_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public string PROJE_KODU { get; set; }
        public string ONAYTIPI { get; set; }
        public int ONAYNUM { get; set; }
        public Nullable<int> BAGLANTI_NO { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
    }
}
