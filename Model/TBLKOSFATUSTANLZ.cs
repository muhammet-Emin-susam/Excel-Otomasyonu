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
    
    public partial class TBLKOSFATUSTANLZ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKOSFATUSTANLZ()
        {
            this.TBLKOSFATKLMANLZ = new HashSet<TBLKOSFATKLMANLZ>();
        }
    
        public int INCKEYNO { get; set; }
        public string FTIRSIP { get; set; }
        public string FATIRS_NO { get; set; }
        public string CARI_KODU { get; set; }
        public short SUBE_KODU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKOSFATKLMANLZ> TBLKOSFATKLMANLZ { get; set; }
    }
}