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
    
    public partial class TBLKOSGENEL
    {
        public string KOSUL_KOD { get; set; }
        public string ACIKLAMA { get; set; }
        public System.DateTime BASLANGICTAR { get; set; }
        public Nullable<System.DateTime> BITISTAR { get; set; }
        public Nullable<System.DateTime> FIATTAR { get; set; }
        public Nullable<System.DateTime> KOSULTAR { get; set; }
        public Nullable<decimal> ISKORANI { get; set; }
        public Nullable<decimal> ISKORANI2 { get; set; }
        public Nullable<decimal> ISKORANI3 { get; set; }
        public Nullable<byte> LISTEFIATI { get; set; }
        public Nullable<short> VADEGUNU { get; set; }
        public Nullable<decimal> PESISKORAN { get; set; }
        public Nullable<decimal> GECIKMEKATSAYI { get; set; }
        public Nullable<short> VADEGUNLERI1 { get; set; }
        public Nullable<short> VADEGUNLERI2 { get; set; }
        public Nullable<short> VADEGUNLERI3 { get; set; }
        public Nullable<short> VADEGUNLERI4 { get; set; }
        public Nullable<byte> VADELISTEFIATI1 { get; set; }
        public Nullable<byte> VADELISTEFIATI2 { get; set; }
        public Nullable<byte> VADELISTEFIATI3 { get; set; }
        public Nullable<byte> VADELISTEFIATI4 { get; set; }
        public Nullable<short> GENELISKTIP1 { get; set; }
        public Nullable<short> GENELISKTIP2 { get; set; }
        public Nullable<short> GENELISKTIP3 { get; set; }
        public Nullable<short> SATIRISKTIP1 { get; set; }
        public Nullable<short> SATIRISKTIP2 { get; set; }
        public Nullable<short> SATIRISKTIP3 { get; set; }
        public Nullable<short> SATIRISKTIP4 { get; set; }
        public Nullable<short> SATIRISKTIP5 { get; set; }
        public Nullable<short> SATIRISKTIP6 { get; set; }
        public string RANGEISK { get; set; }
        public string MIKTUT { get; set; }
        public Nullable<decimal> DEGER1 { get; set; }
        public Nullable<decimal> DEGER2 { get; set; }
        public Nullable<decimal> DEGER3 { get; set; }
        public Nullable<decimal> DEGER4 { get; set; }
        public Nullable<decimal> DEGER5 { get; set; }
        public Nullable<decimal> DEGER6 { get; set; }
        public Nullable<decimal> ISK1 { get; set; }
        public Nullable<decimal> ISK2 { get; set; }
        public Nullable<decimal> ISK3 { get; set; }
        public Nullable<decimal> ISK4 { get; set; }
        public Nullable<decimal> ISK5 { get; set; }
        public Nullable<decimal> ISK6 { get; set; }
        public Nullable<byte> HANGIISK { get; set; }
        public string KAPATILMIS { get; set; }
        public Nullable<System.DateTime> VADETARIHI { get; set; }
        public Nullable<decimal> FAIZORANI { get; set; }
        public Nullable<short> RISKSIZICINVADE { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string ODEKOD { get; set; }
        public string KOSVADETAR { get; set; }
    
        public virtual TBLKOSULMAS TBLKOSULMAS { get; set; }
    }
}
