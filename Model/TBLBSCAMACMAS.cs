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
    
    public partial class TBLBSCAMACMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLBSCAMACMAS()
        {
            this.TBLBSCOLCUMMAS = new HashSet<TBLBSCOLCUMMAS>();
        }
    
        public int INCKEYNO { get; set; }
        public string AMACKOD { get; set; }
        public string ACIKLAMA { get; set; }
        public int MISYONINCKEYNO { get; set; }
        public int STRATEJIINCKEYNO { get; set; }
        public int PERSPEKTIFMASINCKEYNO { get; set; }
        public string GRUPKODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<int> YEDEK3 { get; set; }
        public Nullable<int> YEDEK4 { get; set; }
        public Nullable<decimal> YEDEK5 { get; set; }
        public Nullable<decimal> YEDEK6 { get; set; }
        public Nullable<System.DateTime> YEDEK7 { get; set; }
        public Nullable<System.DateTime> YEDEK8 { get; set; }
        public string YEDEK9 { get; set; }
        public string YEDEK10 { get; set; }
    
        public virtual TBLBSCMISYONMAS TBLBSCMISYONMAS { get; set; }
        public virtual TBLBSCSTRATEJIMAS TBLBSCSTRATEJIMAS { get; set; }
        public virtual TBLBSCPERSPEKTIFMAS TBLBSCPERSPEKTIFMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBSCOLCUMMAS> TBLBSCOLCUMMAS { get; set; }
    }
}