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
    
    public partial class TBLMRPSIPBAGLANTI
    {
        public int INCKEYNO { get; set; }
        public Nullable<int> BAGLANTI_ID { get; set; }
        public Nullable<int> SATSIP_INCKEYNO { get; set; }
        public string ISEMRINO { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public Nullable<System.DateTime> TESLIM_TARIHI { get; set; }
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
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<int> YENIBELGENO { get; set; }
        public string BELGE_TIPI { get; set; }
        public string IUP_ISEMRINO { get; set; }
    
        public virtual TBLISEMRI TBLISEMRI { get; set; }
        public virtual TBLMRPSIPEKRTRA TBLMRPSIPEKRTRA { get; set; }
    }
}
