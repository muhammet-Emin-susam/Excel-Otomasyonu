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
    
    public partial class MGPUANKAMPANYASIKISIT
    {
        public string KAMPANYAKODU { get; set; }
        public string KISITTIPI { get; set; }
        public int KISITNO { get; set; }
        public string BAGLAC { get; set; }
        public string SAHA { get; set; }
        public string ISLEM { get; set; }
        public string DEGER1 { get; set; }
        public string DEGER2 { get; set; }
    
        public virtual MGPUANKAMPANYASI MGPUANKAMPANYASI { get; set; }
    }
}
