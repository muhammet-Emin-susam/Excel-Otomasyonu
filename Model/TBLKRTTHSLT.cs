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
    
    public partial class TBLKRTTHSLT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKRTTHSLT()
        {
            this.TBLKRTTHSLTEK = new HashSet<TBLKRTTHSLTEK>();
        }
    
        public int INCKEYNO { get; set; }
        public System.DateTime TARIH { get; set; }
        public short SUBE_KODU { get; set; }
        public string ALACAKNETHESKODU { get; set; }
        public string BORCNETHESKODU { get; set; }
        public Nullable<int> BNKKSTINCKEYNO { get; set; }
        public byte HARTURU { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<decimal> DUZELTILMISTUTAR { get; set; }
        public Nullable<byte> DOVIZTIPI { get; set; }
        public Nullable<decimal> DOVIZTUTARI { get; set; }
        public Nullable<decimal> DUZELTILMISDOVIZTUTAR { get; set; }
        public string PROJE_KODU { get; set; }
        public string PLASIYERKODU { get; set; }
        public string ONAY { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string V_YEDEK1 { get; set; }
        public string V_YEDEK2 { get; set; }
        public string EKMASRAF { get; set; }
        public string EKMASRAFMUHKOD { get; set; }
        public Nullable<decimal> EKMASRAFTUTAR { get; set; }
    
        public virtual TBLBNKHESSABIT TBLBNKHESSABIT { get; set; }
        public virtual TBLBNKHESSABIT TBLBNKHESSABIT1 { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKRTTHSLTEK> TBLKRTTHSLTEK { get; set; }
    }
}
