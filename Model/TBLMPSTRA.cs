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
    
    public partial class TBLMPSTRA
    {
        public int ISLETME_KODU { get; set; }
        public int SUBE_KODU { get; set; }
        public int INCKEYNO { get; set; }
        public int MPSMASID { get; set; }
        public string KOD { get; set; }
        public string STOK_KODU { get; set; }
        public string YAPKOD { get; set; }
        public short YILKODU { get; set; }
        public short PERIYOT { get; set; }
        public short YILPERIYOT { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public string USEREDIT { get; set; }
        public string KAYIT_TIPI { get; set; }
        public decimal MIKTAR2 { get; set; }
        public short OLCUBR_MIKTAR2 { get; set; }
        public short KUMULETIP { get; set; }
        public System.DateTime BASLAMA_TARIHI { get; set; }
        public System.DateTime BITIS_TARIHI { get; set; }
        public decimal KULMIKTAR { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string S_YEDEK3 { get; set; }
        public string S_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK2 { get; set; }
        public Nullable<byte> B_YEDEK1 { get; set; }
        public Nullable<byte> B_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
    
        public virtual TBLMPSMAS TBLMPSMAS { get; set; }
    }
}
