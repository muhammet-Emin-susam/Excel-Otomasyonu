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
    
    public partial class TBLSTOKHESDEG
    {
        public string HESAPKODU { get; set; }
        public Nullable<int> DURMAGUNU { get; set; }
        public Nullable<decimal> ILKMADDEORAN { get; set; }
        public Nullable<decimal> ISCILIKORAN { get; set; }
        public Nullable<decimal> AMORTISMANORAN { get; set; }
        public Nullable<decimal> GENURETIMGIDERORAN { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<int> YEDEK3 { get; set; }
        public Nullable<int> YEDEK4 { get; set; }
        public Nullable<decimal> YEDEK5 { get; set; }
        public Nullable<decimal> YEDEK6 { get; set; }
        public Nullable<decimal> YEDEK7 { get; set; }
        public Nullable<decimal> YEDEK8 { get; set; }
        public Nullable<System.DateTime> YEDEK9 { get; set; }
        public string YEDEK10 { get; set; }
        public Nullable<decimal> FINANSMANGIDERORAN { get; set; }
        public Nullable<int> ISCILIKDURMAGUNU { get; set; }
        public Nullable<int> AMORTISMANDURMAGUNU { get; set; }
        public Nullable<int> GENURETIMGIDERDURMAGUNU { get; set; }
        public Nullable<int> FINANSMANGIDERDURMAGUNU { get; set; }
    
        public virtual TBLMUPLAN TBLMUPLAN { get; set; }
    }
}