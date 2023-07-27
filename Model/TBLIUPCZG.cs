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
    
    public partial class TBLIUPCZG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLIUPCZG()
        {
            this.TBLIUPCZGDTY = new HashSet<TBLIUPCZGDTY>();
            this.TBLIUPCZGSTK = new HashSet<TBLIUPCZGSTK>();
        }
    
        public short ISLETME_KODU { get; set; }
        public int INCKEYNO { get; set; }
        public int MASINCKEYNO { get; set; }
        public string ISTKODU { get; set; }
        public string MAKINEKODU { get; set; }
        public string MAMULKODU { get; set; }
        public string MAMYAPKOD { get; set; }
        public string OPKODU { get; set; }
        public decimal OMIKTAR { get; set; }
        public Nullable<System.DateTime> OSETUPBASTAR { get; set; }
        public Nullable<System.DateTime> OSETUPBITTAR { get; set; }
        public System.DateTime OOPBASTAR { get; set; }
        public System.DateTime OOPBITTAR { get; set; }
        public string SIPNO { get; set; }
        public Nullable<decimal> DMIKTAR { get; set; }
        public Nullable<System.DateTime> DSETUPBASTAR { get; set; }
        public Nullable<System.DateTime> DSETUPBITTAR { get; set; }
        public Nullable<System.DateTime> DOPBASTAR { get; set; }
        public Nullable<System.DateTime> DOPBITTAR { get; set; }
        public string DISTKODU { get; set; }
        public string DMAKINEKODU { get; set; }
        public string CARIKODU { get; set; }
        public string GELENISEMRINO { get; set; }
        public string KAYITDURUM { get; set; }
        public byte AKTIF { get; set; }
        public string ISEMRIOLUSTUR { get; set; }
        public string PAKETMAMULKODU { get; set; }
        public Nullable<int> OPINCKEYNO { get; set; }
        public Nullable<byte> OPALTERNATIF { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public string C_YEDEK4 { get; set; }
        public string C_YEDEK5 { get; set; }
        public string C_YEDEK6 { get; set; }
        public string C_YEDEK7 { get; set; }
        public string C_YEDEK8 { get; set; }
        public string C_YEDEK9 { get; set; }
        public string C_YEDEK10 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLISTASYON TBLISTASYON { get; set; }
        public virtual TBLIUPMAS TBLIUPMAS { get; set; }
        public virtual TBLOPERATIONS_KATALOG TBLOPERATIONS_KATALOG { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZGDTY> TBLIUPCZGDTY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZGSTK> TBLIUPCZGSTK { get; set; }
    }
}