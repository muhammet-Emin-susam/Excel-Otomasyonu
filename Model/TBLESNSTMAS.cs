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
    
    public partial class TBLESNSTMAS
    {
        public string STOKKODU { get; set; }
        public string YAPKOD { get; set; }
        public string MAMULMU { get; set; }
        public string BILESENMI { get; set; }
        public string ESKIBILESENMI { get; set; }
        public string OTOREC { get; set; }
        public Nullable<decimal> XFORMUL_TOPLAMI { get; set; }
        public Nullable<byte> XURET_OLCU_BR { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public string YAPKODGENELKILIT { get; set; }
        public string YAPKODSATICIKILIT { get; set; }
        public string YAPKODMUSTERIKILIT { get; set; }
        public string YAPKODSATINALMAKILIT { get; set; }
        public string YAPKODSATISKILIT { get; set; }
        public string ONAYTIPI { get; set; }
        public Nullable<int> ONAYNUM { get; set; }
        public Nullable<decimal> FIREORANI { get; set; }
    
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
    }
}
