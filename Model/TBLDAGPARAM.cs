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
    
    public partial class TBLDAGPARAM
    {
        public short SUBE_KODU { get; set; }
        public Nullable<int> DEPOKOD { get; set; }
        public string KASAKODSORULACAKMI { get; set; }
        public string KASAKOD { get; set; }
        public string DOSYADIZIN { get; set; }
        public string KDVDAHILMI { get; set; }
        public string BELGEACIKOLSUNMU { get; set; }
        public string TARTILIMALUYGULANSINMI { get; set; }
        public Nullable<int> AGIRLIKBASLANGICYER { get; set; }
        public Nullable<int> AGIRLIKBASLANGICUZUNLUK { get; set; }
        public string RAFTKBMIKSORULSUNMU { get; set; }
        public string STOKGORSIRA { get; set; }
        public string CARIGORSIRA { get; set; }
        public string DISTKOD { get; set; }
        public string DISTBOLGE { get; set; }
        public string DISTUNVAN { get; set; }
        public string DISTADRES { get; set; }
        public string DISTVERGIDAIRE { get; set; }
        public string DISTVERGINO { get; set; }
        public string DISTTEL { get; set; }
        public string DISTFAX { get; set; }
        public string DISTPOSTAKOD { get; set; }
        public string DISTEPOSTA { get; set; }
        public string DISTHTTPADRES { get; set; }
        public Nullable<int> STOKBAGLANTI { get; set; }
        public string SIPILEIRSSORULSUNMU { get; set; }
        public string KOSULKODU { get; set; }
        public string MALFAZSOR { get; set; }
        public string MALFAZMUDAHALE { get; set; }
        public string ISK1SOR { get; set; }
        public string ISK1MUDAHALE { get; set; }
        public string ISK2SOR { get; set; }
        public string ISK2MUDAHALE { get; set; }
        public string ISK3SOR { get; set; }
        public string ISK3MUDAHALE { get; set; }
        public string GENELISK1SOR { get; set; }
        public string GENELISK1MUDAHALE { get; set; }
        public string GENELISK2SOR { get; set; }
        public string GENELISK3SOR { get; set; }
        public string VADESOR { get; set; }
        public string VADEMUDAHALE { get; set; }
        public string UZAKERISIM { get; set; }
        public string SERVERIP { get; set; }
        public string XMLPATH { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public string C_YEDEK4 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string FISNOSERI { get; set; }
        public string BASFATDUZELTME { get; set; }
        public string MIKKONT { get; set; }
        public string COKLUOLCUBIRIM { get; set; }
        public string KOSULFIYATGUNCELLE { get; set; }
        public string ISK4SOR { get; set; }
        public string ISK4MUDAHALE { get; set; }
        public string ISK5SOR { get; set; }
        public string ISK5MUDAHALE { get; set; }
        public string ISK6SOR { get; set; }
        public string ISK6MUDAHALE { get; set; }
        public string GENELISK2MUDAHALE { get; set; }
        public string GENELISK3MUDAHALE { get; set; }
        public string DISPFATURAYUKLE { get; set; }
        public string KOSULMUDAHALE { get; set; }
        public string OLCUBRMUDAHALE { get; set; }
        public string OZHESAPBILAKTAR { get; set; }
        public string SIFIRGUNSIPAKTAR { get; set; }
        public string DISPYUKSERITAKIP { get; set; }
        public string KREDIKASAKOD { get; set; }
        public int PPCYAZILIM { get; set; }
        public string WEBSRVADRES { get; set; }
        public Nullable<int> FIRMAKODU { get; set; }
        public Nullable<int> ROUTEGUNSAYISI { get; set; }
        public string ROTAUYGULAMASIVAR { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
