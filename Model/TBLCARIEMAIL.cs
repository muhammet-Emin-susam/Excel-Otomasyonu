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
    
    public partial class TBLCARIEMAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCARIEMAIL()
        {
            this.TBLCRMADAY = new HashSet<TBLCRMADAY>();
            this.TBLCRMFIRSAT = new HashSet<TBLCRMFIRSAT>();
            this.TBLCRMSATAKT = new HashSet<TBLCRMSATAKT>();
        }
    
        public string CARI_KOD { get; set; }
        public string YETKILIKISI { get; set; }
        public string UNVAN { get; set; }
        public string TEL { get; set; }
        public string DAHILITEL { get; set; }
        public string CEPTEL { get; set; }
        public string ADRES { get; set; }
        public string ISLEMTIPI { get; set; }
        public string EMAIL { get; set; }
        public string CCMAIL { get; set; }
        public string DUYURU_KOD { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string POSTAKODU { get; set; }
        public string GOREV { get; set; }
        public string CRMDEN { get; set; }
        public string SMSISLEMTIPI { get; set; }
        public string DIZAYNBILGILERI { get; set; }
        public string ULKETELKODU { get; set; }
        public int RECID { get; set; }
        public string EKBILGI { get; set; }
        public Nullable<bool> AKTIF { get; set; }
        public string CEPTEL2 { get; set; }
        public string TEL2 { get; set; }
        public string ULKETEL2KODU { get; set; }
        public string DAHILITEL2 { get; set; }
        public string DIREKTTEL { get; set; }
        public string ULKEDIREKTTELKODU { get; set; }
        public string OZELEMAIL { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string EMUTABAKATEMAIL { get; set; }
        public string EKDOSYAISLEMTIPI { get; set; }
        public string BAMUTABAKATEMAIL { get; set; }
        public string BSMUTABAKATEMAIL { get; set; }
        public string PDFPASSWORD { get; set; }
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLDUYURU TBLDUYURU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMADAY> TBLCRMADAY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMFIRSAT> TBLCRMFIRSAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMSATAKT> TBLCRMSATAKT { get; set; }
    }
}
