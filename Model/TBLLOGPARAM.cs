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
    
    public partial class TBLLOGPARAM
    {
        public short SUBE_KODU { get; set; }
        public string LOGTUTULSUN { get; set; }
        public string RAPLOGAYAZILSIN { get; set; }
        public string DUZELTESKITUT { get; set; }
        public string OTOMATIKLOGSILINSIN { get; set; }
        public Nullable<byte> KACGUNLUK { get; set; }
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
        public Nullable<int> L_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string LCN_PARAM { get; set; }
        public string LCN_ADDRESS { get; set; }
        public Nullable<int> LCN_PORT { get; set; }
        public string BASIMLOG { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}