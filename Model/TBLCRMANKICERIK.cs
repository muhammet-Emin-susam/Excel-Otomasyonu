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
    
    public partial class TBLCRMANKICERIK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCRMANKICERIK()
        {
            this.TBLCRMANK = new HashSet<TBLCRMANK>();
            this.TBLCRMANKCEVAPTRA = new HashSet<TBLCRMANKCEVAPTRA>();
            this.TBLCRMANKSECENEK = new HashSet<TBLCRMANKSECENEK>();
        }
    
        public string ICERIKKODU { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public string KONU { get; set; }
        public string GRUPKODU { get; set; }
        public Nullable<System.DateTime> BASTARIH { get; set; }
        public Nullable<System.DateTime> BITTARIH { get; set; }
        public string DURUM { get; set; }
        public Nullable<byte> CEVAPTIPI { get; set; }
        public Nullable<byte> KATEGORITIPI { get; set; }
        public string KATEGORIALAN { get; set; }
        public Nullable<decimal> AGIRLIK { get; set; }
        public string ONAYTIPI { get; set; }
        public Nullable<int> ONAYNUM { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMANK> TBLCRMANK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMANKCEVAPTRA> TBLCRMANKCEVAPTRA { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLCRMANKICERIKGRUP TBLCRMANKICERIKGRUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMANKSECENEK> TBLCRMANKSECENEK { get; set; }
    }
}
