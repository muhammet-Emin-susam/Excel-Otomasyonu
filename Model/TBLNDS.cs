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
    
    public partial class TBLNDS
    {
        public short SUBE_KODU { get; set; }
        public short KULLANICINO { get; set; }
        public int MODNO { get; set; }
        public int PRGNO { get; set; }
        public Nullable<short> MIKTARDEC { get; set; }
        public Nullable<short> TUTARDEC { get; set; }
        public Nullable<short> DOVTUTDEC { get; set; }
        public Nullable<short> FIRDOVTUTDEC { get; set; }
        public Nullable<short> ORANDEC { get; set; }
        public Nullable<short> FIYATDEC { get; set; }
        public Nullable<short> KURDEC { get; set; }
        public Nullable<short> DOVFIYDEC { get; set; }
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
        public Nullable<System.DateTime> D_YEDEK3 { get; set; }
        public Nullable<System.DateTime> D_YEDEK4 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
