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
    
    public partial class TBLIUPCZGDTY
    {
        public int INCKEYNO { get; set; }
        public int CZGINCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public decimal OMIKTAR { get; set; }
        public Nullable<System.DateTime> OSETUPBASTAR { get; set; }
        public Nullable<System.DateTime> OSETUPBITTAR { get; set; }
        public System.DateTime OOPBASTAR { get; set; }
        public System.DateTime OOPBITTAR { get; set; }
        public decimal DMIKTAR { get; set; }
        public Nullable<System.DateTime> DSETUPBASTAR { get; set; }
        public Nullable<System.DateTime> DSETUPBITTAR { get; set; }
        public Nullable<System.DateTime> DOPBASTAR { get; set; }
        public Nullable<System.DateTime> DOPBITTAR { get; set; }
        public string SIPNO { get; set; }
        public string BATCHID { get; set; }
        public string CARIKODU { get; set; }
        public string ROUTEID { get; set; }
        public string ISEMRIOLUSTUR { get; set; }
        public string ACILANISEMRINO { get; set; }
        public string KAYITDURUM { get; set; }
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
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLIUPCZG TBLIUPCZG { get; set; }
    }
}
