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
    
    public partial class TBLDAGFUNCHIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLDAGFUNCHIST()
        {
            this.TBLDAGFUNCHISTXML = new HashSet<TBLDAGFUNCHISTXML>();
        }
    
        public int INCKEYNO { get; set; }
        public int PROVIDER { get; set; }
        public int FUNCID { get; set; }
        public short SUBE_KODU { get; set; }
        public int PACKETNO { get; set; }
        public string PROCESS { get; set; }
        public Nullable<System.DateTime> PROCBGNTIME { get; set; }
        public Nullable<System.DateTime> PROCENDTIME { get; set; }
        public Nullable<System.DateTime> CONNBEGIN { get; set; }
        public Nullable<System.DateTime> CONNEND { get; set; }
        public byte STATUS { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
    
        public virtual TBLDAGFUNCLIST TBLDAGFUNCLIST { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDAGFUNCHISTXML> TBLDAGFUNCHISTXML { get; set; }
    }
}
