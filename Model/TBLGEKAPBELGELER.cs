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
    
    public partial class TBLGEKAPBELGELER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLGEKAPBELGELER()
        {
            this.TBLGEKAPKALEMLER = new HashSet<TBLGEKAPKALEMLER>();
        }
    
        public int INCKEYNO { get; set; }
        public byte TIP { get; set; }
        public string BELGENO { get; set; }
        public string CARI_KODU { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<double> F_YEDEK5 { get; set; }
        public Nullable<double> F_YEDEK6 { get; set; }
        public Nullable<System.DateTime> D_YEDEK7 { get; set; }
        public Nullable<System.DateTime> D_YEDEK8 { get; set; }
        public string V_YEDEK9 { get; set; }
        public string V_YEDEK10 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLGEKAPKALEMLER> TBLGEKAPKALEMLER { get; set; }
    }
}
