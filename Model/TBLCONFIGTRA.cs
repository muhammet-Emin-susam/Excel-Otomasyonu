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
    
    public partial class TBLCONFIGTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCONFIGTRA()
        {
            this.TBLCONFIGYENIOZELLIKDEGERLER = new HashSet<TBLCONFIGYENIOZELLIKDEGERLER>();
        }
    
        public int INCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public int CONFIGMAS_ID { get; set; }
        public string MAMUL_KODU { get; set; }
        public string HAM_KODU { get; set; }
        public string OPNO { get; set; }
        public decimal MIKTAR { get; set; }
        public string TIP { get; set; }
        public string CONFIGURABLE { get; set; }
        public Nullable<int> ALTERNATIFGRUP_ID { get; set; }
        public string ALTERNATIFGRUP_KODU { get; set; }
        public string YENI_HAM_KODU { get; set; }
        public string YENI_HAM_ADI { get; set; }
        public decimal YENI_MIKTAR { get; set; }
        public string YENI_INSERT_NODE { get; set; }
        public int RECETE_ID { get; set; }
        public int UST_RECETE_ID { get; set; }
        public string ACIKLAMA { get; set; }
        public string DEGISEBILIR { get; set; }
        public string HAVE_INS_DEL_NODES { get; set; }
        public string IS_NEW_NODE { get; set; }
        public string ST_ACIKLAMA { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK4 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK3 { get; set; }
        public Nullable<System.DateTime> D_YEDEK4 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<decimal> UST_FORMUL_TOPLAMI { get; set; }
        public Nullable<int> UST_OLCU_BR { get; set; }
        public string UST_OTOREC { get; set; }
        public string URM_MIKTARSABITLE { get; set; }
        public string URM_STOK_MALIYET { get; set; }
        public string URM_OPKODU { get; set; }
        public Nullable<decimal> URM_F_YEDEK1 { get; set; }
        public Nullable<decimal> URM_F_YEDEK2 { get; set; }
        public string URM_C_YEDEK2 { get; set; }
        public Nullable<int> URM_ONCELIK { get; set; }
        public Nullable<decimal> URM_PLANLAMA_ORANI { get; set; }
        public string URM_C_YEDEK1 { get; set; }
        public string URM_ALTERNATIF_POLITIKASI_DAT { get; set; }
        public string URM_ALTERNATIF_POLITIKASI_ACF { get; set; }
        public string URM_ALTERNATIF_POLITIKASI_USK { get; set; }
        public string URM_ALTERNATIF_POLITIKASI_MRP { get; set; }
        public Nullable<System.DateTime> URM_GECERLILIK_TARIHI { get; set; }
        public string URM_SETNO { get; set; }
        public string URM_GEC_SON_SETNO { get; set; }
        public string URM_GEC_SON_BILESEN { get; set; }
        public string URM_GEC_SON_DURUM { get; set; }
        public string IS_INSERT_MODE { get; set; }
        public Nullable<int> STOKURM_INCKEYNO { get; set; }
        public string FOUND_RECETE { get; set; }
        public Nullable<int> URUN_GRUBU_ID { get; set; }
        public string URUN_GRUBU { get; set; }
        public string ESKI_HAM_KODU { get; set; }
        public string ESKI_HAM_ADI { get; set; }
        public Nullable<decimal> BIRIM_MALIYET { get; set; }
        public string MAMYAPKOD { get; set; }
        public string HAMYAPKOD { get; set; }
        public string YENI_HAMYAPKOD { get; set; }
        public string ESKI_HAMYAPKOD { get; set; }
        public string URM_ISTKODU { get; set; }
        public decimal URM_SETUPSURE { get; set; }
        public decimal URM_URETSURE { get; set; }
        public decimal URM_GECISSURE { get; set; }
        public decimal URM_OVERLAPMIK { get; set; }
        public decimal URM_ISCILIKMAL { get; set; }
        public decimal URM_DIGERMAL { get; set; }
        public decimal URM_GENELMAL { get; set; }
        public string URM_OPERASYON_UAK { get; set; }
        public string URM_SON_OPERASYON { get; set; }
        public decimal URM_OPMIK { get; set; }
        public string OLCU_BR1 { get; set; }
        public string OLCU_BR2 { get; set; }
        public Nullable<decimal> PAY_1 { get; set; }
        public Nullable<decimal> PAYDA_1 { get; set; }
        public string OLCU_BR3 { get; set; }
        public Nullable<decimal> PAY2 { get; set; }
        public Nullable<decimal> PAYDA2 { get; set; }
        public string SATICI_KODU { get; set; }
        public string URETICI_KODU { get; set; }
        public string GRUP_KODU { get; set; }
        public string KOD_1 { get; set; }
        public string KOD_2 { get; set; }
        public string KOD_3 { get; set; }
        public string KOD_4 { get; set; }
        public string KOD_5 { get; set; }
        public string MALITUR { get; set; }
        public string MALIGRUP { get; set; }
        public Nullable<decimal> ISCILIK_GIDERI { get; set; }
        public Nullable<decimal> ENERJI_GIDERI { get; set; }
        public Nullable<decimal> AMORTISMAN_GIDERI { get; set; }
        public Nullable<decimal> YARSERVIS_GIDERI { get; set; }
        public Nullable<decimal> YEDPARCA_GIDERI { get; set; }
        public Nullable<decimal> MALGIDER1 { get; set; }
        public Nullable<decimal> MALGIDER2 { get; set; }
        public Nullable<decimal> MALGIDER3 { get; set; }
        public Nullable<decimal> MALGIDER4 { get; set; }
        public Nullable<decimal> MALGIDER5 { get; set; }
        public Nullable<decimal> OPRISCILIKMALIYETI { get; set; }
        public Nullable<decimal> OPRDIGERMALIYETI { get; set; }
        public string MALIYET_KAYIT_VAR { get; set; }
        public Nullable<decimal> TOPLAM_GIDERLER { get; set; }
        public Nullable<decimal> TOPLAM_BILESEN_MALIYETI { get; set; }
        public Nullable<decimal> MALGIDER6 { get; set; }
        public Nullable<decimal> MALGIDER7 { get; set; }
        public Nullable<decimal> MALGIDER8 { get; set; }
        public Nullable<decimal> MALGIDER9 { get; set; }
        public Nullable<decimal> MALGIDER10 { get; set; }
    
        public virtual TBLCONFIGALTERNATIFGRUP TBLCONFIGALTERNATIFGRUP { get; set; }
        public virtual TBLCONFIGMAS TBLCONFIGMAS { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLCONFIGURUNGRUP TBLCONFIGURUNGRUP { get; set; }
        public virtual TBLISTASYON TBLISTASYON { get; set; }
        public virtual TBLCONFIGTRAEK TBLCONFIGTRAEK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCONFIGYENIOZELLIKDEGERLER> TBLCONFIGYENIOZELLIKDEGERLER { get; set; }
    }
}
