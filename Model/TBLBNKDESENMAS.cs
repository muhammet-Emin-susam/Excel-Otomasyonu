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
    
    public partial class TBLBNKDESENMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLBNKDESENMAS()
        {
            this.TBLBNKDESENTRA = new HashSet<TBLBNKDESENTRA>();
        }
    
        public int INCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public string DESEN_KODU { get; set; }
        public string DESEN_ADI { get; set; }
        public byte TURU { get; set; }
        public byte DESENTIPI { get; set; }
        public byte DOSYATIPI { get; set; }
        public string DOSYA_ADI { get; set; }
        public Nullable<byte> DOSYA_ADI_OLUSTURULSUN { get; set; }
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
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBNKDESENTRA> TBLBNKDESENTRA { get; set; }
    }
}
