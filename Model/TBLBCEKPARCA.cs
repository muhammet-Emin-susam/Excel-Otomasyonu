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
    
    public partial class TBLBCEKPARCA
    {
        public int OTOSIRANO { get; set; }
        public short SUBE_KODU { get; set; }
        public string A_V { get; set; }
        public string BORDRO_NO { get; set; }
        public string CARI_KODU { get; set; }
        public string ACIKLAMA { get; set; }
        public string TLDOVIZ { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<byte> DOVIZTIP { get; set; }
        public Nullable<decimal> DOVTUTAR { get; set; }
        public string PROJE_KODU { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK4 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK3 { get; set; }
        public Nullable<System.DateTime> D_YEDEK4 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string ONAYTIPI { get; set; }
        public int ONAYNUM { get; set; }
        public int VONAYNUM { get; set; }
        public string VONAYTIPI { get; set; }
        public string CARI_ACIKLAMA { get; set; }
        public string SC_NO { get; set; }
        public Nullable<System.DateTime> VADETRH { get; set; }
        public string PLASIYER_KODU { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
    }
}
