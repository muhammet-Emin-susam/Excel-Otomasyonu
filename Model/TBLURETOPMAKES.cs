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
    
    public partial class TBLURETOPMAKES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLURETOPMAKES()
        {
            this.TBLURETGECISSURE = new HashSet<TBLURETGECISSURE>();
            this.TBLURETHATDENGESONUC = new HashSet<TBLURETHATDENGESONUC>();
            this.TBLURETSUBOPERATIONS = new HashSet<TBLURETSUBOPERATIONS>();
        }
    
        public int INCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public short OP_DEGER_TIPI { get; set; }
        public string OP_DEGER { get; set; }
        public short MAK_DEGER_TIPI { get; set; }
        public string MAK_DEGER { get; set; }
        public short URUN_DEGER_TIPI { get; set; }
        public string URUN_DEGER { get; set; }
        public decimal URETSURE { get; set; }
        public string URETSURETIPI { get; set; }
        public decimal URETMIK { get; set; }
        public string URETMIKTIPI { get; set; }
        public Nullable<decimal> PARTIMIK { get; set; }
        public string PARTIMIKTIPI { get; set; }
        public Nullable<decimal> GECISMIK { get; set; }
        public string GECISMIKTIPI { get; set; }
        public Nullable<decimal> CEVRIMSURE { get; set; }
        public string CEVRIMSURETIPI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public string C_YEDEK4 { get; set; }
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
        public string YAPKOD { get; set; }
        public Nullable<int> MIN_CALIS_KAY { get; set; }
        public Nullable<int> MAX_CALIS_KAY { get; set; }
        public Nullable<decimal> GECISSURE { get; set; }
        public string GECISSURETIPI { get; set; }
        public Nullable<int> ONCELIK { get; set; }
        public string OPNO { get; set; }
        public string GECISMIK_TANIMTIPI { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURETGECISSURE> TBLURETGECISSURE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURETHATDENGESONUC> TBLURETHATDENGESONUC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURETSUBOPERATIONS> TBLURETSUBOPERATIONS { get; set; }
    }
}
