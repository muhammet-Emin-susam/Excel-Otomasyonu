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
    
    public partial class TBLFIATGRUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLFIATGRUP()
        {
            this.TBLKOSDETAY = new HashSet<TBLKOSDETAY>();
            this.TBLSTOKFIAT = new HashSet<TBLSTOKFIAT>();
        }
    
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public string FGRUP { get; set; }
        public string GACIKLAMA { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKOSDETAY> TBLKOSDETAY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKFIAT> TBLSTOKFIAT { get; set; }
    }
}