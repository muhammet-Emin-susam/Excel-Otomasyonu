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
    
    public partial class TBLSTOKASORTITRA
    {
        public int INCKEYNO { get; set; }
        public string ASORTIKOD { get; set; }
        public string STOK_KODU { get; set; }
        public string ASORTISTOKKOD { get; set; }
        public string ASORTIOZKOD { get; set; }
        public string ASORTIOZDEGER { get; set; }
        public Nullable<byte> VARSAYILAN { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK2 { get; set; }
        public Nullable<int> L_YEDEK3 { get; set; }
        public Nullable<int> L_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK4 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string V_YEDEK1 { get; set; }
        public string V_YEDEK2 { get; set; }
    
        public virtual TBLASORTIMAS TBLASORTIMAS { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
    }
}
