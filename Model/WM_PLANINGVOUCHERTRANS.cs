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
    
    public partial class WM_PLANINGVOUCHERTRANS
    {
        public int ID { get; set; }
        public int PLANINGVOUCHERID { get; set; }
        public Nullable<int> ORDERREF { get; set; }
        public string ORDERNUMBER { get; set; }
        public Nullable<int> ORDERLINEREF { get; set; }
        public Nullable<int> ARPREF { get; set; }
        public string ARPCODE { get; set; }
        public Nullable<int> WHREF { get; set; }
        public string WHCODE { get; set; }
        public Nullable<int> ITEMREF { get; set; }
        public string ITEMCODE { get; set; }
        public Nullable<int> VARIANTREF { get; set; }
        public string VARIANTCODE { get; set; }
        public Nullable<int> UNITREF { get; set; }
        public string UNITCODE { get; set; }
        public Nullable<decimal> CONVFACT1 { get; set; }
        public Nullable<decimal> CONVFACT2 { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public Nullable<decimal> REMAMOUNT { get; set; }
        public Nullable<decimal> PLANNEDAMOUNT { get; set; }
        public Nullable<int> ASSIGNTOUSERREF { get; set; }
        public string ASSIGNTO { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public string FIRM { get; set; }
        public string PERIOD { get; set; }
        public Nullable<int> LINETYPE { get; set; }
        public Nullable<int> GLOBTRANS { get; set; }
        public Nullable<int> SHIPINFOREF { get; set; }
        public string SHIPINFOCODE { get; set; }
    }
}