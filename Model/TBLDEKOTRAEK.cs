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
    
    public partial class TBLDEKOTRAEK
    {
        public int INCKEY_NO { get; set; }
        public short SUBE_KODU { get; set; }
        public string DEKSERI_NO { get; set; }
        public int DEKDEKONT_NO { get; set; }
        public int DEKSIRA_NO { get; set; }
        public string FTSERI_NO { get; set; }
        public string CARIUNVAN { get; set; }
        public string CARIKIMLIKVERGI_NO { get; set; }
        public string MALCINS { get; set; }
        public string MALMIKTAR { get; set; }
        public string GGB_NO { get; set; }
        public string ARACIKIMLIKVERGI_NO { get; set; }
        public string KDVDONEMI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string VERGI_DAIRESI { get; set; }
    
        public virtual TBLDEKOTRA TBLDEKOTRA { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}