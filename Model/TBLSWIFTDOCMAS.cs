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
    
    public partial class TBLSWIFTDOCMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSWIFTDOCMAS()
        {
            this.TBLSWIFTDOCTRA = new HashSet<TBLSWIFTDOCTRA>();
        }
    
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public int INCKEYNO { get; set; }
        public string ISLEM_REFERANS_NO { get; set; }
        public string ILGILI_REFERANS_NO { get; set; }
        public string HESAP_NO { get; set; }
        public string SIRA_NO { get; set; }
        public Nullable<decimal> ACILIS_BAKIYE { get; set; }
        public Nullable<decimal> KAPANIS_BAKIYE { get; set; }
        public Nullable<decimal> OLASI_BAKIYE { get; set; }
        public string DOSYA_ADI { get; set; }
        public string DOSYA_DIZIN { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSWIFTDOCTRA> TBLSWIFTDOCTRA { get; set; }
    }
}