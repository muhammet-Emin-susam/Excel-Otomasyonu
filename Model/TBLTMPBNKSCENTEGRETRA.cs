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
    
    public partial class TBLTMPBNKSCENTEGRETRA
    {
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public byte TIP { get; set; }
        public string SCNO { get; set; }
        public string SC_ALB_NO { get; set; }
        public Nullable<System.DateTime> VADE_TARIHI { get; set; }
        public Nullable<decimal> BRUTTUTAR { get; set; }
        public string GONDERILDI { get; set; }
        public string DURUMU { get; set; }
        public string DESEN_KODU { get; set; }
        public string AKIBETDESEN_KODU { get; set; }
        public int MASINCKEYNO { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLTMPBNKSCENTEGREMAS TBLTMPBNKSCENTEGREMAS { get; set; }
    }
}
