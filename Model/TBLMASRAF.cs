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
    
    public partial class TBLMASRAF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLMASRAF()
        {
            this.TBLMASRAFMAS = new HashSet<TBLMASRAFMAS>();
            this.TBLMRPMAKINE = new HashSet<TBLMRPMAKINE>();
        }
    
        public string MKOD { get; set; }
        public string MUHKOD { get; set; }
        public string ACIKLAMA { get; set; }
        public short SUBE_KODU { get; set; }
        public string SATMUHKOD { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string S_YEDEK3 { get; set; }
        public string S_YEDEK4 { get; set; }
        public string S_YEDEK5 { get; set; }
        public Nullable<short> ISLETME_KODU { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMASRAFMAS> TBLMASRAFMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMRPMAKINE> TBLMRPMAKINE { get; set; }
    }
}
