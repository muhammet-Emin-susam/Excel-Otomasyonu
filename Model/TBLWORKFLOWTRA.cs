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
    
    public partial class TBLWORKFLOWTRA
    {
        public short SUBE_KODU { get; set; }
        public string PATHKODU { get; set; }
        public Nullable<int> ONAYNUMARASI { get; set; }
        public Nullable<int> MODULNO { get; set; }
        public Nullable<short> PROGRAMNO { get; set; }
        public int INCKEYNO { get; set; }
        public string DURUMU { get; set; }
        public Nullable<System.DateTime> GIRISZAMANI { get; set; }
        public Nullable<System.DateTime> CIKISZAMANI { get; set; }
        public string ACIKLAMA { get; set; }
        public short KULLANICINO { get; set; }
        public Nullable<short> KAPKULLANICINO { get; set; }
        public string DBOPTYPE { get; set; }
        public string ILKACIKLAMA { get; set; }
        public Nullable<int> ONCEKIINCKEYNO { get; set; }
        public string WFONTABLES { get; set; }
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
        public Nullable<int> ONLINE_ONAY_ID { get; set; }
    
        public virtual TBLKULLANP TBLKULLANP { get; set; }
        public virtual TBLWORKPATHTRA TBLWORKPATHTRA { get; set; }
    }
}