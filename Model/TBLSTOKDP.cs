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
    
    public partial class TBLSTOKDP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSTOKDP()
        {
            this.TBLDEPOKILIT = new HashSet<TBLDEPOKILIT>();
        }
    
        public short DEPO_KODU { get; set; }
        public string DEPO_ISMI { get; set; }
        public string DEPO_KILITLE { get; set; }
        public string CARI_KODU { get; set; }
        public string EKSIBAKIYE { get; set; }
        public string FIAT_TIPI { get; set; }
        public short SUBE_KODU { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string EMANETDEPO { get; set; }
        public short KILIT_POLITIKASI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDEPOKILIT> TBLDEPOKILIT { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLSTOKDPEK TBLSTOKDPEK { get; set; }
    }
}
