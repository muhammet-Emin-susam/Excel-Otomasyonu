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
    
    public partial class TBLKRTSOZTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKRTSOZTRA()
        {
            this.TBLKRTSOZKST = new HashSet<TBLKRTSOZKST>();
        }
    
        public int INCKEYNO { get; set; }
        public int KRTSOZMASINCKEYNO { get; set; }
        public short TAKSITBAS { get; set; }
        public short TAKSITBIT { get; set; }
        public byte TAHSILATSEKLI { get; set; }
        public short VADEATLAMA { get; set; }
        public byte BLOKAJGUNILAVEGUN { get; set; }
        public short BLOKAJGUN { get; set; }
        public byte VADEGUNILAVEGUN { get; set; }
        public short VADEGUN { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string V_YEDEK1 { get; set; }
        public string V_YEDEK2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKRTSOZKST> TBLKRTSOZKST { get; set; }
        public virtual TBLKRTSOZMAS TBLKRTSOZMAS { get; set; }
    }
}
