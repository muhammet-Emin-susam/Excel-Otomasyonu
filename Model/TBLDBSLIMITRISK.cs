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
    
    public partial class TBLDBSLIMITRISK
    {
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public string CARI_KOD { get; set; }
        public byte BANKID { get; set; }
        public string HESAPNO { get; set; }
        public Nullable<decimal> LIMITTUT { get; set; }
        public Nullable<decimal> RISKTUT { get; set; }
        public Nullable<decimal> TAHSILKABULTUT { get; set; }
        public Nullable<decimal> TOPLAMFATTUT { get; set; }
        public Nullable<decimal> KREDIKABULFATTUT { get; set; }
        public Nullable<decimal> KREDIYETERSIZFATTUT { get; set; }
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
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
