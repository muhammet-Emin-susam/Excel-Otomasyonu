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
    
    public partial class TBLREVYANSNO
    {
        public string YANSITMANO { get; set; }
        public string REVNO { get; set; }
        public string KULAMAC { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<int> YEDEK3 { get; set; }
        public Nullable<int> YEDEK4 { get; set; }
        public Nullable<decimal> YEDEK5 { get; set; }
        public Nullable<decimal> YEDEK6 { get; set; }
        public Nullable<System.DateTime> YEDEK7 { get; set; }
        public Nullable<System.DateTime> YEDEK8 { get; set; }
        public string YEDEK9 { get; set; }
        public string YEDEK10 { get; set; }
    
        public virtual TBLSETNOTAR TBLSETNOTAR { get; set; }
    }
}
