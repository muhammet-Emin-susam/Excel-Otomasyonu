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
    
    public partial class TBLIHRMASRAFTIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLIHRMASRAFTIP()
        {
            this.TBLIHRMASRAFDEKONT = new HashSet<TBLIHRMASRAFDEKONT>();
        }
    
        public string KOD { get; set; }
        public string GRUP { get; set; }
        public string ACIKLAMA { get; set; }
        public string MUH_KOD { get; set; }
        public Nullable<int> KDVORAN { get; set; }
        public string INDKDV { get; set; }
        public string MALBEDELHESABI { get; set; }
        public Nullable<short> ITHIHRTIP { get; set; }
        public string BEYANNAMEDEGOSTER { get; set; }
        public short SUBE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public short ISLETME_KODU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRMASRAFDEKONT> TBLIHRMASRAFDEKONT { get; set; }
    }
}
