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
    
    public partial class TBLMASRAFTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLMASRAFTRA()
        {
            this.TBLMASRAFTRADETAY = new HashSet<TBLMASRAFTRADETAY>();
        }
    
        public int INCKEYNO { get; set; }
        public int MAS_ID { get; set; }
        public System.DateTime MASRAF_TARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public decimal TUTAR { get; set; }
        public string TIP_KODU { get; set; }
        public Nullable<decimal> KDV_ORANI { get; set; }
        public string MUSTERI_FATURA { get; set; }
        public string MUS_CARIKODU { get; set; }
        public string FATURASI_VAR { get; set; }
        public string FAT_CARIKODU { get; set; }
        public string FIS_FATURANO { get; set; }
        public byte ODEMEYONTEMI { get; set; }
        public string PROJE_KODU { get; set; }
        public string REFERANS_KODU { get; set; }
        public string ONAYTIPI { get; set; }
        public int ONAYNUM { get; set; }
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
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLCASABIT TBLCASABIT1 { get; set; }
        public virtual TBLMASRAFMAS TBLMASRAFMAS { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMASRAFTRADETAY> TBLMASRAFTRADETAY { get; set; }
    }
}
