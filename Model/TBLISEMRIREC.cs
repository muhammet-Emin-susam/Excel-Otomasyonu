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
    
    public partial class TBLISEMRIREC
    {
        public string ISEMRINO { get; set; }
        public string MAMUL_KODU { get; set; }
        public string HAM_KODU { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public string STOK_MALIYET { get; set; }
        public string MIKTARSABITLE { get; set; }
        public Nullable<System.DateTime> KAYIT_TARIHI { get; set; }
        public Nullable<System.DateTime> GECERLILIK_TARIHI { get; set; }
        public string GEC_SON_BILESEN { get; set; }
        public Nullable<decimal> GEC_SON_MIKTAR { get; set; }
        public byte GEC_FLAG { get; set; }
        public Nullable<System.DateTime> BASLANGIC_TARIHI { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string S_YEDEK3 { get; set; }
        public string S_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK2 { get; set; }
        public Nullable<byte> B_YEDEK1 { get; set; }
        public Nullable<byte> B_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string PROJE_KODU { get; set; }
        public string OPERASYON_UAK { get; set; }
        public string SON_OPERASYON { get; set; }
        public string OPR_BIL { get; set; }
        public string OPNO { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<decimal> OPMIK { get; set; }
        public string ISTKODU { get; set; }
        public Nullable<decimal> SETUPSURE { get; set; }
        public Nullable<decimal> URETSURE { get; set; }
        public Nullable<decimal> GECISSURE { get; set; }
        public Nullable<decimal> OVERLAPMIK { get; set; }
        public Nullable<decimal> ISCILIKMAL { get; set; }
        public Nullable<decimal> DIGERMAL { get; set; }
        public Nullable<decimal> GENELMAL { get; set; }
        public Nullable<int> ONCELIK { get; set; }
        public Nullable<decimal> PLANLAMA_ORANI { get; set; }
        public string ALTERNATIF_POLITIKASI_DAT { get; set; }
        public string ALTERNATIF_POLITIKASI_ACF { get; set; }
        public string ALTERNATIF_POLITIKASI_USK { get; set; }
        public string ALTERNATIF_POLITIKASI_MRP { get; set; }
        public string SARFEDILEN_MAMUL { get; set; }
        public string OPKODU { get; set; }
        public string MAMYAPKOD { get; set; }
        public string HAMYAPKOD { get; set; }
        public string GECSONBILYAPKOD { get; set; }
        public Nullable<int> MAKINCKEYNO { get; set; }
        public int INCKEYNO { get; set; }
        public Nullable<int> UST_RECETE_ID { get; set; }
        public Nullable<decimal> ISTASYON_KAPASITE { get; set; }
        public Nullable<short> DEPO_KODU { get; set; }
        public string SERINO { get; set; }
        public int BILESEN_ALTERNATIF_KODU { get; set; }
        public decimal MALIYET_YUZDESI { get; set; }
    
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLESNYAPMAS TBLESNYAPMAS1 { get; set; }
        public virtual TBLESNYAPMAS TBLESNYAPMAS2 { get; set; }
        public virtual TBLISEMRI TBLISEMRI { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
        public virtual TBLISTASYON TBLISTASYON { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
        public virtual TBLMRPMAKINE TBLMRPMAKINE { get; set; }
        public virtual TBLISEMRIRECEK TBLISEMRIRECEK { get; set; }
    }
}
