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
    
    public partial class MGLOGYEDEK
    {
        public int LOGID { get; set; }
        public string KASAKOD { get; set; }
        public System.DateTime TARIH { get; set; }
        public string ACIKLAMA { get; set; }
        public string KULLANICI { get; set; }
        public string SATISELEMANI { get; set; }
        public string FATURANO { get; set; }
        public string CARIKOD { get; set; }
        public string STOKKOD { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public Nullable<int> ODEMETIPI { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<System.DateTime> ODEMETARIHI { get; set; }
        public Nullable<decimal> GENELTOPLAM { get; set; }
        public Nullable<int> LINKID { get; set; }
        public byte ISLEM { get; set; }
    }
}
