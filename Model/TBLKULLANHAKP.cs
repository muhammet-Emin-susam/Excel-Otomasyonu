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
    
    public partial class TBLKULLANHAKP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKULLANHAKP()
        {
            this.TBLKULLANPROGP = new HashSet<TBLKULLANPROGP>();
        }
    
        public short SUBE_KODU { get; set; }
        public short KULLANICI_NO { get; set; }
        public int MODUL_NO { get; set; }
        public string SORGU { get; set; }
        public string KAYIT { get; set; }
        public string DUZELTME { get; set; }
        public string SILME { get; set; }
        public Nullable<int> YEDEK1 { get; set; }
        public Nullable<int> YEDEK2 { get; set; }
        public string YEDEK3 { get; set; }
        public string YEDEK4 { get; set; }
        public Nullable<System.DateTime> YEDEK5 { get; set; }
        public Nullable<System.DateTime> YEDEK6 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public int TRH_KILIT_GUNGECMIS { get; set; }
        public int TRH_KILIT_GUNGELECEK { get; set; }
        public string FIS_BASIM { get; set; }
    
        public virtual TBLKULLANP TBLKULLANP { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKULLANPROGP> TBLKULLANPROGP { get; set; }
    }
}
