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
    
    public partial class TBLCAODETRA
    {
        public string ODEKOD { get; set; }
        public Nullable<byte> SIRANO { get; set; }
        public Nullable<decimal> ORAN { get; set; }
        public Nullable<byte> VADETIPI { get; set; }
        public Nullable<short> GUN { get; set; }
        public string KOSUL { get; set; }
        public int INCKEYNO { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public string C_YEDEK4 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK4 { get; set; }
        public Nullable<System.DateTime> D_YEDEK5 { get; set; }
        public Nullable<System.DateTime> D_YEDEK6 { get; set; }
        public string V_YEDEK7 { get; set; }
        public string V_YEDEK8 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string RAPORKODU { get; set; }
    
        public virtual TBLCAODEMAS TBLCAODEMAS { get; set; }
    }
}
