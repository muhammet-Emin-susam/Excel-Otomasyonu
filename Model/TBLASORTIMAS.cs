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
    
    public partial class TBLASORTIMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLASORTIMAS()
        {
            this.TBLASORTITRA = new HashSet<TBLASORTITRA>();
            this.TBLISEMRI = new HashSet<TBLISEMRI>();
            this.TBLSTOKASORTITRA = new HashSet<TBLSTOKASORTITRA>();
        }
    
        public short ISLETME_KODU { get; set; }
        public string ASORTIKOD { get; set; }
        public string ASORTIACIK { get; set; }
        public string BOZKOD { get; set; }
        public string BDEGERKOD { get; set; }
        public string AOZKOD { get; set; }
        public int INCKEYNO { get; set; }
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
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLASORTITRA> TBLASORTITRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISEMRI> TBLISEMRI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKASORTITRA> TBLSTOKASORTITRA { get; set; }
    }
}