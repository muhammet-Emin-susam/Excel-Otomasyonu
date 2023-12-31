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
    
    public partial class WM_VOUCHERTRANS
    {
        public int ID { get; set; }
        public int MASTERREF { get; set; }
        public Nullable<int> ITEMREF { get; set; }
        public string ITEMCODE { get; set; }
        public Nullable<int> UNITREF { get; set; }
        public string UNITCODE { get; set; }
        public Nullable<decimal> CONVFACT1 { get; set; }
        public Nullable<decimal> CONVFACT2 { get; set; }
        public Nullable<int> DESTWHREF { get; set; }
        public int WHREF { get; set; }
        public string DESTWHCODE { get; set; }
        public string WHCODE { get; set; }
        public string DESTADDRESS { get; set; }
        public string ADDRESS { get; set; }
        public string DESTPALLET { get; set; }
        public string PALLET { get; set; }
        public string TRACKINGNUMBER { get; set; }
        public Nullable<int> ORDERREF { get; set; }
        public string ORDERNO { get; set; }
        public string FIRM { get; set; }
        public string PERIOD { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public string SPECODE { get; set; }
        public string PROJECTCODE { get; set; }
        public Nullable<int> PROJECTREF { get; set; }
        public Nullable<int> VARIANTREF { get; set; }
        public string VARIANTCODE { get; set; }
        public string USERCODE { get; set; }
        public Nullable<int> USERREF { get; set; }
        public short IOCODE { get; set; }
        public short VOUCHERTYPE { get; set; }
        public System.DateTime DATE { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<System.DateTime> EXPIRATIONDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<int> ERPFICHEREF { get; set; }
        public string ERPFICHECODE { get; set; }
        public string VOUCHERGUID { get; set; }
        public string VOUCHERTRANSGUID { get; set; }
        public Nullable<int> ORDERLINEREF { get; set; }
        public Nullable<int> SPECODEREF { get; set; }
        public Nullable<int> ADDRESSREF { get; set; }
        public Nullable<int> DESTADDRESSREF { get; set; }
        public Nullable<int> PARENTLINEREF { get; set; }
        public Nullable<int> PROMOTION { get; set; }
        public int PALLETTYPE { get; set; }
        public Nullable<int> PRORD_REFERENCE { get; set; }
        public Nullable<int> SOURCEWSREF { get; set; }
        public Nullable<int> SRCPOLN_REFERENCE { get; set; }
        public Nullable<int> PLN_STTRANS_PER_NR { get; set; }
        public Nullable<int> PLN_STTRANS_REFERENCE { get; set; }
        public Nullable<int> SHIPINFOREF { get; set; }
        public string SHIPINFOCODE { get; set; }
        public Nullable<int> ARPREF { get; set; }
        public string ARPCODE { get; set; }
        public Nullable<int> DEMANDREF { get; set; }
        public Nullable<int> DEMANDLINEREF { get; set; }
        public Nullable<int> IMPORTOPERATIONREF { get; set; }
        public Nullable<int> IMPORTOPERATIONLINEREF { get; set; }
        public string UNITSETCODE { get; set; }
        public Nullable<int> UNITSETREF { get; set; }
    }
}
