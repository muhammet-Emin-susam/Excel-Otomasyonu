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
    
    public partial class TBLKKCARISTOK
    {
        public string CARIKODU { get; set; }
        public string STOKKODU { get; set; }
        public string DEPKODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public string GRUPKODU { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<short> ISLETME_KODU { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK5 { get; set; }
        public Nullable<decimal> F_YEDEK6 { get; set; }
        public Nullable<System.DateTime> D_YEDEK7 { get; set; }
        public Nullable<System.DateTime> D_YEDEK8 { get; set; }
        public string V_YEDEK10 { get; set; }
        public string V_YEDEK11 { get; set; }
        public short REVNO { get; set; }
        public string AKTIF { get; set; }
        public string OPKODU { get; set; }
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLKKDEP TBLKKDEP { get; set; }
        public virtual TBLKKGRP TBLKKGRP { get; set; }
        public virtual TBLOPERATIONS_KATALOG TBLOPERATIONS_KATALOG { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
    }
}
