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
    
    public partial class TBLKKPROCESSTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKKPROCESSTRA()
        {
            this.TBLKKHARICOLCUM = new HashSet<TBLKKHARICOLCUM>();
        }
    
        public int INCKEYNO { get; set; }
        public Nullable<short> ISLETME_KODU { get; set; }
        public int PROCESSMAS_ID { get; set; }
        public string OLCUMTIPI { get; set; }
        public int OLCUMSIRA { get; set; }
        public Nullable<decimal> OLCUMDEGERINUM { get; set; }
        public string OLCUMDEGERIALF { get; set; }
        public string ACIKLAMA { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<int> I_YEDEK5 { get; set; }
        public Nullable<int> I_YEDEK6 { get; set; }
        public Nullable<decimal> F_YEDEK5 { get; set; }
        public Nullable<decimal> F_YEDEK7 { get; set; }
        public Nullable<decimal> F_YEDEK8 { get; set; }
        public Nullable<decimal> F_YEDEK6 { get; set; }
        public Nullable<System.DateTime> D_YEDEK7 { get; set; }
        public Nullable<System.DateTime> D_YEDEK8 { get; set; }
        public Nullable<System.DateTime> D_YEDEK9 { get; set; }
        public Nullable<System.DateTime> D_YEDEK10 { get; set; }
        public string V_YEDEK10 { get; set; }
        public string V_YEDEK11 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKKHARICOLCUM> TBLKKHARICOLCUM { get; set; }
        public virtual TBLKKOLCUM TBLKKOLCUM { get; set; }
        public virtual TBLKKPROCESSMAS TBLKKPROCESSMAS { get; set; }
    }
}