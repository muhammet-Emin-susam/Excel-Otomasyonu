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
    
    public partial class TBLSTOKFIAT
    {
        public int INCKEYNO { get; set; }
        public string STOKKODU { get; set; }
        public string A_S { get; set; }
        public Nullable<decimal> FIYAT1 { get; set; }
        public Nullable<decimal> FIYAT2 { get; set; }
        public Nullable<decimal> FIYAT3 { get; set; }
        public Nullable<decimal> FIYAT4 { get; set; }
        public Nullable<byte> FIYATDOVIZTIPI { get; set; }
        public Nullable<System.DateTime> KAYITTAR { get; set; }
        public Nullable<System.DateTime> DEGISIKTAR { get; set; }
        public System.DateTime BASTAR { get; set; }
        public Nullable<System.DateTime> BITTAR { get; set; }
        public string FIYATGRUBU { get; set; }
        public Nullable<short> KAYITKULLID { get; set; }
        public Nullable<short> DEGISIKLIKKULLID { get; set; }
        public string ONAYTIPI { get; set; }
        public Nullable<int> ONAYNUM { get; set; }
        public string FIYATLISTEKODU { get; set; }
        public string FIYATLISTEACIK { get; set; }
        public string YAPKOD { get; set; }
        public Nullable<short> OLCUBR { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public Nullable<short> KAYIT_SUBE_KODU { get; set; }
    
        public virtual TBLFIATGRUP TBLFIATGRUP { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
    }
}