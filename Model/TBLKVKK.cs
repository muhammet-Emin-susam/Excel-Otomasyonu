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
    
    public partial class TBLKVKK
    {
        public int INCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public Nullable<byte> KAYITTIPI { get; set; }
        public string HESAP_KODU { get; set; }
        public Nullable<short> PROG_ADI { get; set; }
        public Nullable<short> ALAN_ADI { get; set; }
        public Nullable<System.DateTime> BAS_TARIH { get; set; }
        public Nullable<System.DateTime> BIT_TARIH { get; set; }
        public Nullable<System.DateTime> IPTAL_TARIH { get; set; }
        public Nullable<System.DateTime> ANONIM_TARIH { get; set; }
        public string ISLEM_AMACI { get; set; }
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
        public Nullable<int> REMINDER_ID { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
