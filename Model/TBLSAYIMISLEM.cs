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
    
    public partial class TBLSAYIMISLEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSAYIMISLEM()
        {
            this.TBLSAYIMISLEMHAREKETBAG = new HashSet<TBLSAYIMISLEMHAREKETBAG>();
        }
    
        public int INCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public string ISLEM_NO { get; set; }
        public string SAYIM_KODU { get; set; }
        public string PROJE_KODU { get; set; }
        public string DEPO_KODU { get; set; }
        public string HUCRE_KODU { get; set; }
        public string HUCRE_GRUPKODU { get; set; }
        public string STOK_KODU { get; set; }
        public string URUN_GRUBU { get; set; }
        public string GRUP_KODU { get; set; }
        public string KOD1 { get; set; }
        public string KOD2 { get; set; }
        public string KOD3 { get; set; }
        public string KOD4 { get; set; }
        public string KOD5 { get; set; }
        public Nullable<System.DateTime> HAREKET_TARIHI { get; set; }
        public Nullable<byte> MALIYET_TIPI { get; set; }
        public Nullable<System.DateTime> MALIYET_SINIRTARIHI { get; set; }
        public Nullable<System.DateTime> BAKIYE_SINIRTARIHI { get; set; }
        public string NEGATIF_STOK { get; set; }
        public string ACIKLAMA { get; set; }
        public string MAHSUP { get; set; }
        public Nullable<int> MAH_FAZ_BDET { get; set; }
        public string MAH_FAZ_BMUH { get; set; }
        public Nullable<int> MAH_FAZ_ADET { get; set; }
        public string MAH_FAZ_AMUH { get; set; }
        public Nullable<int> MAH_EKS_BDET { get; set; }
        public string MAH_EKS_BMUH { get; set; }
        public Nullable<int> MAH_EKS_ADET { get; set; }
        public string MAH_EKS_AMUH { get; set; }
        public Nullable<System.DateTime> ISLEME_TARIHI { get; set; }
        public string ISLEYEN_KULLANICI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSAYIMISLEMHAREKETBAG> TBLSAYIMISLEMHAREKETBAG { get; set; }
    }
}