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
    
    public partial class TBLURETHAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLURETHAT()
        {
            this.TBLISEMRI = new HashSet<TBLISEMRI>();
            this.TBLMALIANAGHAT = new HashSet<TBLMALIANAGHAT>();
            this.TBLSTOKURS = new HashSet<TBLSTOKURS>();
        }
    
        public short ISLETME_KODU { get; set; }
        public string HAT_KODU { get; set; }
        public string HAT_ISMI { get; set; }
        public string YM_SARF_HAT_BAZINDA { get; set; }
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
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISEMRI> TBLISEMRI { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMALIANAGHAT> TBLMALIANAGHAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURS> TBLSTOKURS { get; set; }
    }
}