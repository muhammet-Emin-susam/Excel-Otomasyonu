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
    
    public partial class TBLBKMSOZMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLBKMSOZMAS()
        {
            this.TBLBKMSOZDET = new HashSet<TBLBKMSOZDET>();
            this.TBLMAKBKM = new HashSet<TBLMAKBKM>();
        }
    
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public string SOZLESMENO { get; set; }
        public Nullable<int> SOZTIPINCKEYNO { get; set; }
        public System.DateTime BASTAR { get; set; }
        public System.DateTime BITTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public string CARIKOD { get; set; }
        public string AKTIF { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string CYEDEK1 { get; set; }
        public string CYEDEK2 { get; set; }
        public Nullable<int> IYEDEK1 { get; set; }
        public Nullable<int> IYEDEK2 { get; set; }
        public Nullable<decimal> FYEDEK1 { get; set; }
        public Nullable<decimal> FYEDEK2 { get; set; }
        public Nullable<System.DateTime> DYEDEK1 { get; set; }
        public Nullable<System.DateTime> DYEDEK2 { get; set; }
        public string STRYEDEK1 { get; set; }
        public string STRYEDEK2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBKMSOZDET> TBLBKMSOZDET { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLBKMSOZTIP TBLBKMSOZTIP { get; set; }
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMAKBKM> TBLMAKBKM { get; set; }
    }
}
