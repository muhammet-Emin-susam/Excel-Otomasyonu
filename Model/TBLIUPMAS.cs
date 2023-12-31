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
    
    public partial class TBLIUPMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLIUPMAS()
        {
            this.TBLIUPCZG = new HashSet<TBLIUPCZG>();
            this.TBLIUPHATA = new HashSet<TBLIUPHATA>();
            this.TBLIUPMAKPRF = new HashSet<TBLIUPMAKPRF>();
            this.TBLIUPSIP = new HashSet<TBLIUPSIP>();
            this.TBLIUPSTKGBKY = new HashSet<TBLIUPSTKGBKY>();
            this.TBLIUPTRA = new HashSet<TBLIUPTRA>();
        }
    
        public int INCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public System.DateTime HAZIRLAMAZAMANI { get; set; }
        public Nullable<System.DateTime> GONDERIMZAMANI { get; set; }
        public Nullable<System.DateTime> GELISZAMANI { get; set; }
        public Nullable<System.DateTime> AKTARIMZAMANI { get; set; }
        public Nullable<System.DateTime> YAYINZAMANI { get; set; }
        public short STATUS { get; set; }
        public Nullable<short> PLANTYPE { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<short> SATSIPKONTROL { get; set; }
        public Nullable<short> ISEMIRKONTROL { get; set; }
        public string MRPPLANBCKNO { get; set; }
        public string GIDENXMLPATH { get; set; }
        public string GELENXMLPATH { get; set; }
        public string MESAJID { get; set; }
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
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string REQUESTXMLMESSAGE { get; set; }
        public string RESPONSEXMLMESSAGE { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZG> TBLIUPCZG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPHATA> TBLIUPHATA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPMAKPRF> TBLIUPMAKPRF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPSIP> TBLIUPSIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPSTKGBKY> TBLIUPSTKGBKY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPTRA> TBLIUPTRA { get; set; }
    }
}
