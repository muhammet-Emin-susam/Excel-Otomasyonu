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
    
    public partial class TBLEMUTABAKATTRADETAY
    {
        public int INCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public int TRAINCKEYNO { get; set; }
        public string BELGENO { get; set; }
        public string FTIRSIP { get; set; }
        public decimal TUTAR { get; set; }
        public string BORCALACAK { get; set; }
        public Nullable<decimal> DOVIZTUTAR { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string GIB_FATIRS_NO { get; set; }
        public string MODULNO { get; set; }
        public string ULKE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK4 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK3 { get; set; }
        public Nullable<System.DateTime> D_YEDEK4 { get; set; }
    
        public virtual TBLEMUTABAKATTRA TBLEMUTABAKATTRA { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
    }
}
