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
    
    public partial class TBLEARSIVMASTAX
    {
        public int EARSMASINC { get; set; }
        public Nullable<decimal> TAXABLEAMOUNT { get; set; }
        public Nullable<decimal> TAXAMOUNT { get; set; }
        public Nullable<decimal> CALCULATIONSEQUENCENUMERIC { get; set; }
        public Nullable<decimal> TRANSACTIONCURRENCYTAXAMOUNT { get; set; }
        public Nullable<decimal> TAXPERCENT { get; set; }
        public Nullable<decimal> BASEUNITMEASURE { get; set; }
        public Nullable<decimal> PERUNITAMOUNT { get; set; }
        public string TAXEXEMPTIONREASON { get; set; }
        public string NAME { get; set; }
        public string TAXTYPECODE { get; set; }
        public Nullable<int> TAXEXEMPTIONREASONCODE { get; set; }
    
        public virtual TBLEARSIVMAS TBLEARSIVMAS { get; set; }
    }
}
