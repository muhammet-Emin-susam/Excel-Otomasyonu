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
    
    public partial class TBLMPS
    {
        public short ISLETME_KODU { get; set; }
        public string STOK_KODU { get; set; }
        public string YAPKOD { get; set; }
        public Nullable<int> MPS_PERIYOT_NO { get; set; }
        public Nullable<decimal> FORECAST_MIKTAR { get; set; }
        public Nullable<decimal> FORECAST_DZLT_MIKTAR { get; set; }
        public Nullable<decimal> SIPARIS_MIKTAR { get; set; }
        public Nullable<decimal> MIN_STOK { get; set; }
        public Nullable<decimal> MAX_STOK { get; set; }
        public Nullable<decimal> LOT_SIZE { get; set; }
        public Nullable<decimal> MPS_MIKTAR { get; set; }
        public Nullable<decimal> PERSONSTOKBAKIYE { get; set; }
        public Nullable<decimal> ATP { get; set; }
        public int INCKEYNO { get; set; }
        public Nullable<int> YILKODU { get; set; }
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
        public string V_YEDEK1 { get; set; }
        public string V_YEDEK2 { get; set; }
    
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
    }
}
