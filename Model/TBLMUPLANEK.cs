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
    
    public partial class TBLMUPLANEK
    {
        public string KOD { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<decimal> KULL1N { get; set; }
        public Nullable<decimal> KULL2N { get; set; }
        public Nullable<decimal> KULL3N { get; set; }
        public Nullable<decimal> KULL4N { get; set; }
        public Nullable<decimal> KULL5N { get; set; }
        public Nullable<decimal> KULL6N { get; set; }
        public Nullable<decimal> KULL7N { get; set; }
        public Nullable<decimal> KULL8N { get; set; }
        public string KULL1S { get; set; }
        public string KULL2S { get; set; }
        public string KULL3S { get; set; }
        public string KULL4S { get; set; }
        public string KULL5S { get; set; }
        public string KULL6S { get; set; }
        public string KULL7S { get; set; }
        public string KULL8S { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<decimal> YEDEK3 { get; set; }
        public Nullable<decimal> YEDEK4 { get; set; }
        public string YEDEK5 { get; set; }
        public string YEDEK6 { get; set; }
        public Nullable<byte> YEDEK7 { get; set; }
        public Nullable<short> YEDEK8 { get; set; }
        public Nullable<int> YEDEK9 { get; set; }
    
        public virtual TBLMUPLAN TBLMUPLAN { get; set; }
    }
}
