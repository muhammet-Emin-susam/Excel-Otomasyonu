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
    
    public partial class TBLCEKILIST
    {
        public string DOSYANO { get; set; }
        public string CEKILISTNO { get; set; }
        public string FATIRS_NO { get; set; }
        public string FTIRSIP { get; set; }
        public string CARI_KOD { get; set; }
        public string IRSALIYENO { get; set; }
        public string STOK_KODU { get; set; }
        public Nullable<int> SIRA { get; set; }
        public string GTIP { get; set; }
        public Nullable<decimal> ADET { get; set; }
        public Nullable<decimal> BRT_AGIRLIK { get; set; }
        public Nullable<decimal> NET_AGIRLIK { get; set; }
        public string PAKET_KODU { get; set; }
        public string PAKET_NO { get; set; }
        public string KONTEYNER_KODU { get; set; }
        public string KONTEYNER_NO { get; set; }
        public Nullable<decimal> PAKET_AGIRLIK { get; set; }
        public Nullable<decimal> MIKTAR2 { get; set; }
        public string MUHURNO { get; set; }
        public string SEVKNO { get; set; }
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public Nullable<decimal> PAKET_HACIM { get; set; }
        public Nullable<decimal> BRT_AGIRLIK2 { get; set; }
        public Nullable<decimal> NET_AGIRLIK2 { get; set; }
        public Nullable<decimal> KAPADEDI { get; set; }
    
        public virtual TBLIHRDOSYAMAS TBLIHRDOSYAMAS { get; set; }
    }
}
