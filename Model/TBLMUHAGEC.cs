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
    
    public partial class TBLMUHAGEC
    {
        public short SUBE_KODU { get; set; }
        public string MGECDK { get; set; }
        public string KS_KOD { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string KOD { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<short> KULL_ID { get; set; }
        public Nullable<System.DateTime> EVRAKTARIHI { get; set; }
        public string MUHREFKOD { get; set; }
        public string REFKOD { get; set; }
        public string ENTEGREFKEY { get; set; }
        public Nullable<byte> KAYITTIPI { get; set; }
        public Nullable<byte> DOVIZ_TIPI { get; set; }
        public Nullable<decimal> DOVTUT { get; set; }
        public string UPDATE_KODU { get; set; }
        public string MODULCHOICE { get; set; }
        public string YONTEM { get; set; }
        public int SIRA { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<decimal> YEDEK3 { get; set; }
        public Nullable<decimal> YEDEK4 { get; set; }
        public string YEDEK5 { get; set; }
        public string YEDEK6 { get; set; }
        public Nullable<byte> YEDEK7 { get; set; }
        public Nullable<short> YEDEK8 { get; set; }
        public Nullable<int> YEDEK9 { get; set; }
        public Nullable<System.DateTime> YEDEK10 { get; set; }
        public string PROJE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string ONAYTIPI { get; set; }
        public int ONAYNUM { get; set; }
        public string GUID { get; set; }
        public Nullable<int> ISLEMSIRANO { get; set; }
        public string KAYITSEKLI { get; set; }
        public string BELGE_TIPI { get; set; }
        public string BELGE_NO { get; set; }
        public Nullable<System.DateTime> BELGE_TARIH { get; set; }
        public string ODEME_TURU { get; set; }
        public string KAYNAKDOVKUR { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
    }
}