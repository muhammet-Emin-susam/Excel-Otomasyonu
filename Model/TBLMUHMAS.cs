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
    
    public partial class TBLMUHMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLMUHMAS()
        {
            this.TBLMUHFIS = new HashSet<TBLMUHFIS>();
        }
    
        public byte AY_KODU { get; set; }
        public string MAS_FISNO { get; set; }
        public string MASACIK1 { get; set; }
        public string MASACIK2 { get; set; }
        public Nullable<int> RES_YEVM_NO { get; set; }
        public Nullable<int> IAS_RES_YEVM_NO { get; set; }
        public string FISTIP { get; set; }
        public string UPDATE_KODU { get; set; }
        public string VERSIYON { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public string YEDEK3 { get; set; }
        public Nullable<short> YEDEK4 { get; set; }
        public Nullable<short> YEDEK5 { get; set; }
        public string YEDEK6 { get; set; }
        public string YEDEK7 { get; set; }
        public Nullable<int> YEDEK8 { get; set; }
        public Nullable<System.DateTime> YEDEK9 { get; set; }
        public short SUBE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string MASACIK3 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMUHFIS> TBLMUHFIS { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
