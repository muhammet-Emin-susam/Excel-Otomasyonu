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
    
    public partial class TBLSEVKMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSEVKMAS()
        {
            this.TBLSEVKTRA = new HashSet<TBLSEVKTRA>();
        }
    
        public short SUBE_KODU { get; set; }
        public byte TIP { get; set; }
        public string BELGENO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<System.DateTime> SEVKTARIHI { get; set; }
        public string KOD1 { get; set; }
        public string KOD2 { get; set; }
        public string ACIK1 { get; set; }
        public string ACIK2 { get; set; }
        public string ACIK3 { get; set; }
        public string KAMYONNO { get; set; }
        public string UPDATEKODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK2 { get; set; }
        public Nullable<short> I_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK4 { get; set; }
        public Nullable<System.DateTime> T_YEDEK1 { get; set; }
        public Nullable<System.DateTime> T_YEDEK2 { get; set; }
        public string ACIK4 { get; set; }
        public string ACIK5 { get; set; }
        public string ACIK6 { get; set; }
        public string ACIK7 { get; set; }
        public string ACIK8 { get; set; }
        public string ACIK9 { get; set; }
        public string ACIK10 { get; set; }
        public string SOFORISIM { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSEVKTRA> TBLSEVKTRA { get; set; }
    }
}
