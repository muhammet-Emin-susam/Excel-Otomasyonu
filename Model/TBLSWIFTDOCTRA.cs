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
    
    public partial class TBLSWIFTDOCTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSWIFTDOCTRA()
        {
            this.TBLSWIFTDOCTRAEK = new HashSet<TBLSWIFTDOCTRAEK>();
        }
    
        public int INCKEYNO { get; set; }
        public int DOSYA_ID { get; set; }
        public int SIRA_NO { get; set; }
        public Nullable<System.DateTime> VALOR_TARIHI { get; set; }
        public Nullable<System.DateTime> GIRIS_TARIHI { get; set; }
        public string GOSTERGE { get; set; }
        public string PARA_BIRIM { get; set; }
        public decimal TUTAR { get; set; }
        public string HAREKET_KODU { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<byte> AKTARILDI { get; set; }
        public Nullable<System.DateTime> AKTARIM_TARIH { get; set; }
        public string KURAL_KODU { get; set; }
        public string ALACAK_NETHESKODU { get; set; }
        public string BORC_NETHESKODU { get; set; }
        public string ANALIZ_KODU { get; set; }
        public Nullable<byte> BELGE_TIPI { get; set; }
        public string ISLEM_TIPI { get; set; }
        public string KOD { get; set; }
        public string METIN { get; set; }
        public string BELGENO { get; set; }
        public byte KURAL_AMACI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK2 { get; set; }
        public Nullable<short> I_YEDEK3 { get; set; }
        public Nullable<short> I_YEDEK4 { get; set; }
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
    
        public virtual TBLSWIFTDOCMAS TBLSWIFTDOCMAS { get; set; }
        public virtual TBLSWIFTKURAL TBLSWIFTKURAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSWIFTDOCTRAEK> TBLSWIFTDOCTRAEK { get; set; }
    }
}
