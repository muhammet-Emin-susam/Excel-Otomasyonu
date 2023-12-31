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
    
    public partial class TBLMRPISCI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLMRPISCI()
        {
            this.TBLBKMSBPER = new HashSet<TBLBKMSBPER>();
            this.TBLBKMTALEP = new HashSet<TBLBKMTALEP>();
            this.TBLKKMAS = new HashSet<TBLKKMAS>();
            this.TBLKKOLCUMTRA = new HashSet<TBLKKOLCUMTRA>();
            this.TBLKKPROCESSMAS = new HashSet<TBLKKPROCESSMAS>();
            this.TBLKKTRA = new HashSet<TBLKKTRA>();
            this.TBLUAKKAYNAK = new HashSet<TBLUAKKAYNAK>();
            this.TBLUAKMAS = new HashSet<TBLUAKMAS>();
            this.TBLURETCIZELGEBAKIMPLANI = new HashSet<TBLURETCIZELGEBAKIMPLANI>();
            this.TBLURETKAYNAKHAR = new HashSet<TBLURETKAYNAKHAR>();
            this.TBLURETPERMAKES = new HashSet<TBLURETPERMAKES>();
        }
    
        public string SICILNO { get; set; }
        public string ISYERI { get; set; }
        public int INCKEYNO { get; set; }
        public string ISIM { get; set; }
        public string ISTKODU { get; set; }
        public string GOREVKODU { get; set; }
        public Nullable<decimal> BIRIMMALIYET { get; set; }
        public string DURUM { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK5 { get; set; }
        public Nullable<decimal> F_YEDEK6 { get; set; }
        public Nullable<System.DateTime> D_YEDEK7 { get; set; }
        public Nullable<System.DateTime> D_YEDEK8 { get; set; }
        public string V_YEDEK10 { get; set; }
        public string V_YEDEK11 { get; set; }
        public string GRUP { get; set; }
        public Nullable<short> ISLETME_KODU { get; set; }
        public string KAYNAK_TIPI { get; set; }
        public string KAYNAK_GRUBU { get; set; }
        public Nullable<decimal> KAYNAK_SAYISI { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<short> ONEMDERECESI { get; set; }
        public string KAYNAK_TAKIBI { get; set; }
        public Nullable<System.DateTime> SON_KULLANMA_TARIHI { get; set; }
        public Nullable<decimal> TOPLAM_OMUR { get; set; }
        public string TOPLAM_OMUR_BR { get; set; }
        public Nullable<int> GOZ_SAYISI { get; set; }
        public string TAMIR_EDILEBILIR { get; set; }
        public Nullable<decimal> ORT_BAKIM_SURESI { get; set; }
        public string ORT_BAKIM_SURESI_BR { get; set; }
        public Nullable<short> MAX_BAKIM_SAYISI { get; set; }
        public Nullable<decimal> BAKIMDA_YIPRANMA_PAYI { get; set; }
        public string ISEMRI_BOYUNCA_REZERVE { get; set; }
        public string CARI_KOD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBKMSBPER> TBLBKMSBPER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBKMTALEP> TBLBKMTALEP { get; set; }
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKKMAS> TBLKKMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKKOLCUMTRA> TBLKKOLCUMTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKKPROCESSMAS> TBLKKPROCESSMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKKTRA> TBLKKTRA { get; set; }
        public virtual TBLMRPISCIEK TBLMRPISCIEK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLUAKKAYNAK> TBLUAKKAYNAK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLUAKMAS> TBLUAKMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURETCIZELGEBAKIMPLANI> TBLURETCIZELGEBAKIMPLANI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURETKAYNAKHAR> TBLURETKAYNAKHAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURETPERMAKES> TBLURETPERMAKES { get; set; }
    }
}
