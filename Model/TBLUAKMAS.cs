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
    
    public partial class TBLUAKMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLUAKMAS()
        {
            this.TBLUAKKAYNAK = new HashSet<TBLUAKKAYNAK>();
        }
    
        public string ISEMRINO { get; set; }
        public string CONFSIRANO { get; set; }
        public int INCKEYNO { get; set; }
        public string STOKKODU { get; set; }
        public string OPKODU { get; set; }
        public string OPSIRANO { get; set; }
        public string ISTASYONKODU { get; set; }
        public Nullable<decimal> SIMULTANEOPR { get; set; }
        public Nullable<int> MRPMAKINENO { get; set; }
        public Nullable<int> MRPISCINO { get; set; }
        public System.DateTime BASLANGICTARIH { get; set; }
        public Nullable<byte> BASLANGICVARDIYA { get; set; }
        public decimal SURE { get; set; }
        public Nullable<byte> SURETIPI { get; set; }
        public System.DateTime BITISTARIHSAAT { get; set; }
        public string AKTIVITEKODU { get; set; }
        public string ARIZAKODU { get; set; }
        public string ISLENDI { get; set; }
        public Nullable<decimal> URETILENMIKTAR { get; set; }
        public Nullable<decimal> FIREMIKTAR { get; set; }
        public string PROJEKODU { get; set; }
        public string REVNO { get; set; }
        public string SERILOTNO { get; set; }
        public Nullable<short> USKDEPOKODU { get; set; }
        public short SUBE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string ACIK1 { get; set; }
        public string ACIK2 { get; set; }
        public string ACIK3 { get; set; }
        public string ACIK4 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK5 { get; set; }
        public Nullable<decimal> F_YEDEK6 { get; set; }
        public Nullable<System.DateTime> D_YEDEK7 { get; set; }
        public Nullable<System.DateTime> D_YEDEK8 { get; set; }
        public string V_YEDEK10 { get; set; }
        public string V_YEDEK11 { get; set; }
        public string STOKURS_INCKEYNO { get; set; }
        public string YAPKOD { get; set; }
        public string OPR_KAYNAK_VIEW { get; set; }
        public string BASLADI_BITMEDI { get; set; }
        public string SUBISEMRI_NO { get; set; }
        public byte OLCUBRMIKTAR { get; set; }
        public byte OLCUBRFIRE { get; set; }
    
        public virtual TBLISEMRI TBLISEMRI { get; set; }
        public virtual TBLISTASYON TBLISTASYON { get; set; }
        public virtual TBLMRPISCI TBLMRPISCI { get; set; }
        public virtual TBLMRPMAKINE TBLMRPMAKINE { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLUAKAKTIVITESABIT TBLUAKAKTIVITESABIT { get; set; }
        public virtual TBLUAKARIZASABIT TBLUAKARIZASABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLUAKKAYNAK> TBLUAKKAYNAK { get; set; }
    }
}