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
    
    public partial class TBLKOSVADEMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKOSVADEMAS()
        {
            this.TBLKOSDETAY = new HashSet<TBLKOSDETAY>();
            this.TBLKOSVADEGUN = new HashSet<TBLKOSVADEGUN>();
        }
    
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public string VADEKODU { get; set; }
        public string VADEACIKLAMA { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<byte> B_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKOSDETAY> TBLKOSDETAY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKOSVADEGUN> TBLKOSVADEGUN { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
