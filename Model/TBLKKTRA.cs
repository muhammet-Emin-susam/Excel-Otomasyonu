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
    
    public partial class TBLKKTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKKTRA()
        {
            this.TBLKKOLCUMTRA = new HashSet<TBLKKOLCUMTRA>();
        }
    
        public string KKNO { get; set; }
        public int ITEMSIRANO { get; set; }
        public Nullable<int> KKISCI { get; set; }
        public Nullable<System.DateTime> KKTARIHI { get; set; }
        public Nullable<decimal> KONTROLMIKTAR { get; set; }
        public Nullable<decimal> KABULREDMIKTAR { get; set; }
        public string KABULRED { get; set; }
        public string ITEMSERILOTNO { get; set; }
        public string ACIKLAMA { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<int> ISLETME_KODU { get; set; }
        public string ACIK1 { get; set; }
        public string ACIK2 { get; set; }
        public string ACIK3 { get; set; }
        public string ACIK4 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<int> I_YEDEK5 { get; set; }
        public Nullable<int> I_YEDEK6 { get; set; }
        public Nullable<decimal> F_YEDEK5 { get; set; }
        public Nullable<decimal> F_YEDEK6 { get; set; }
        public Nullable<decimal> F_YEDEK7 { get; set; }
        public Nullable<decimal> F_YEDEK8 { get; set; }
        public Nullable<System.DateTime> D_YEDEK7 { get; set; }
        public Nullable<System.DateTime> D_YEDEK8 { get; set; }
        public string V_YEDEK10 { get; set; }
        public string V_YEDEK11 { get; set; }
        public Nullable<decimal> HURDAMIK { get; set; }
        public string ITEMSERILOTNO_2 { get; set; }
        public string ITEMSERI_ACIK1 { get; set; }
        public string ITEMSERI_ACIK2 { get; set; }
        public short OLCU_BIRIMI { get; set; }
        public Nullable<decimal> ITEM_SERIMIKTAR2 { get; set; }
        public string ITEMSERILOTNO_3 { get; set; }
        public string ITEMSERILOTNO_4 { get; set; }
        public string ITEMSERI_ACIK3 { get; set; }
        public string ITEMSERI_ACIK4 { get; set; }
        public Nullable<System.DateTime> SON_KULLANMA_TARIHI { get; set; }
    
        public virtual TBLKKMAS TBLKKMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKKOLCUMTRA> TBLKKOLCUMTRA { get; set; }
        public virtual TBLMRPISCI TBLMRPISCI { get; set; }
    }
}