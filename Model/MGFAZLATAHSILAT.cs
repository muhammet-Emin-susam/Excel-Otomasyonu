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
    
    public partial class MGFAZLATAHSILAT
    {
        public int SIRA { get; set; }
        public Nullable<int> SUBEKODU { get; set; }
        public string CKOD { get; set; }
        public string TAHNO { get; set; }
        public int CARPAN { get; set; }
        public decimal TUTAR { get; set; }
        public System.DateTime ISLEMTAR { get; set; }
        public Nullable<int> OPSIRA { get; set; }
        public string BELGETIPI { get; set; }
    
        public virtual MGODEMEPLANIDETAY MGODEMEPLANIDETAY { get; set; }
    }
}