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
    
    public partial class TBLCARIPARAM
    {
        public short ISLETME_KODU { get; set; }
        public string GRUP_ISIMG { get; set; }
        public Nullable<decimal> FAIZ { get; set; }
        public string MIKTAR { get; set; }
        public string BASLIK1 { get; set; }
        public string BASLIK2 { get; set; }
        public string BASLIK3 { get; set; }
        public string BASLIK4 { get; set; }
        public string BASLIK5 { get; set; }
        public string BASLIK6 { get; set; }
        public string BASLIK7 { get; set; }
        public string BASLIK8 { get; set; }
        public string BASLIK9 { get; set; }
        public string BASLIK10 { get; set; }
        public string BASLIK11 { get; set; }
        public string BASLIK12 { get; set; }
        public string BASLIK13 { get; set; }
        public string BASLIK14 { get; set; }
        public string BASLIK15 { get; set; }
        public string BASLIK16 { get; set; }
        public string FIELD_SEC { get; set; }
        public string POS_UYGULAMA { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public string C_YEDEK4 { get; set; }
        public string C_YEDEK5 { get; set; }
        public string C_YEDEK6 { get; set; }
        public string C_YEDEK7 { get; set; }
        public string C_YEDEK8 { get; set; }
        public string C_YEDEK9 { get; set; }
        public string C_YEDEK10 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<byte> CARISORGU_KAYNAGI { get; set; }
        public string NPS_KULLANICI_AD { get; set; }
        public string NPS_KULLANICI_SIFRE { get; set; }
        public string CARIKUR_DEGIS { get; set; }
        public Nullable<int> OZHES_SABITGUN { get; set; }
        public string OZHES_DOVTIP { get; set; }
        public string OZHES_OPSIYON { get; set; }
        public string OZHES_CIKILMASIN { get; set; }
        public string KURFARKIHESAPLA { get; set; }
        public string DOVCARI_BELGEDE { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
    }
}