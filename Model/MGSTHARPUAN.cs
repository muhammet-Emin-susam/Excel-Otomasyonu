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
    
    public partial class MGSTHARPUAN
    {
        public int MGSIRA { get; set; }
        public int STRANO { get; set; }
        public string KAMPANYAKODU { get; set; }
        public decimal TUTAR { get; set; }
        public Nullable<System.DateTime> SKT { get; set; }
    
        public virtual TBLSTHAR TBLSTHAR { get; set; }
    }
}
