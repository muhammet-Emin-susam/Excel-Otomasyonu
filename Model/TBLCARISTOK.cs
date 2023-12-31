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
    
    public partial class TBLCARISTOK
    {
        public int INCKEYNO { get; set; }
        public string STOK_KODU { get; set; }
        public string CARI_KOD { get; set; }
        public string CARISTOK_KODU { get; set; }
        public string CARISTOKISMI { get; set; }
        public string OLCU_BR { get; set; }
        public Nullable<decimal> LOT_SIZE { get; set; }
        public Nullable<decimal> TEDARIK_SURESI { get; set; }
        public Nullable<decimal> MINSIPARISMIKTARI { get; set; }
        public string KILIT { get; set; }
        public string YUKLEME_PERIYOD_TIPI { get; set; }
        public Nullable<byte> YUKLEME_GUNU { get; set; }
        public Nullable<byte> NAKLIYE_SURESI { get; set; }
        public string KESINLESME_PERIYOD_TIPI { get; set; }
        public Nullable<byte> KESINLESME_SURESI { get; set; }
        public string HABER_PERIYOD_TIPI { get; set; }
        public Nullable<byte> PLAN_HAFTA_SAYISI { get; set; }
        public Nullable<byte> PLAN_AY_SAYISI { get; set; }
        public Nullable<decimal> DAGITIM_ORANI { get; set; }
        public string SIPARIS_POLITIKA { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<decimal> FAZTESORAN { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<decimal> SATISKDVORANI { get; set; }
        public Nullable<decimal> ALISKDVORANI { get; set; }
        public Nullable<decimal> FAZLAURORAN { get; set; }
        public string ABCKODU { get; set; }
        public string PERFORMANSKODU { get; set; }
        public Nullable<decimal> AZAMI_STOK { get; set; }
        public Nullable<decimal> ASGARI_STOK { get; set; }
        public Nullable<decimal> KUL_MIK { get; set; }
        public string YAPKOD { get; set; }
        public short SUBE_KODU { get; set; }
        public Nullable<short> ISLETME_KODU { get; set; }
        public Nullable<decimal> KULL1N { get; set; }
        public Nullable<decimal> KULL2N { get; set; }
        public Nullable<decimal> KULL3N { get; set; }
        public Nullable<decimal> KULL4N { get; set; }
        public Nullable<decimal> KULL5N { get; set; }
        public Nullable<decimal> KULL6N { get; set; }
        public Nullable<decimal> KULL7N { get; set; }
        public Nullable<decimal> KULL8N { get; set; }
        public string KULL1S { get; set; }
        public string KULL2S { get; set; }
        public string KULL3S { get; set; }
        public string KULL4S { get; set; }
        public string KULL5S { get; set; }
        public string KULL6S { get; set; }
        public string KULL7S { get; set; }
        public string KULL8S { get; set; }
        public string EXTRAINFO { get; set; }
        public Nullable<System.DateTime> BASTAR { get; set; }
        public Nullable<short> ONCELIK { get; set; }
        public string SIPARISKARSILAMA { get; set; }
        public string SIPARISTAKIP { get; set; }
        public string PLANLAMATIPI { get; set; }
        public decimal MAXSIPARISMIKTARI { get; set; }
        public decimal ZAMANSKALASI { get; set; }
        public string TEDARIKCITERCIH { get; set; }
        public string AUPSIPARISBAK { get; set; }
        public decimal MALIYET { get; set; }
        public string KAPASITEPERYOTTIPI { get; set; }
        public Nullable<decimal> KAPASITE { get; set; }
        public Nullable<decimal> TEDARIK_MIKTARI { get; set; }
        public string FASON { get; set; }
        public string SAT_SIP_YONTEM { get; set; }
        public string ISEMRI_YONTEM { get; set; }
        public int ORANLAMA_DONEMI { get; set; }
        public string FASON_ISEMRI { get; set; }
        public Nullable<decimal> KABULYUZDESI { get; set; }
        public string REZERV_BAK_TAKIP { get; set; }
        public string ONEMSIZ_STOK { get; set; }
        public string KESINLESEN_GUNCELLENMESIN { get; set; }
        public string SIPARIS_ONAYLI { get; set; }
        public string REC_ISEM_OLUS { get; set; }
        public short URET_GIRIS_DEPO { get; set; }
        public short URET_CIKIS_DEPO { get; set; }
        public Nullable<decimal> URETIM_TRANSFER_SURESI { get; set; }
        public string MRP_POLITIKA { get; set; }
        public int DDMRP_GECMIS_HAFTA { get; set; }
        public int DDMRP_GELECEK_HAFTA { get; set; }
        public string KESINLESEN_GUNCELLENMESIN_MIK { get; set; }
        public string REFERANS_KODU { get; set; }
        public string PROJE_KODU { get; set; }
        public short FIREDEPO { get; set; }
        public string FIRESTOK { get; set; }
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLMUHAREF TBLMUHAREF { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
        public virtual TBLCARISTOKEK TBLCARISTOKEK { get; set; }
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLCARISTOKMUSTERIEK TBLCARISTOKMUSTERIEK { get; set; }
        public virtual TBLCARISTOKPLANEK TBLCARISTOKPLANEK { get; set; }
    }
}
