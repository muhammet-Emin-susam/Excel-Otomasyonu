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
    
    public partial class MGKISITDETAY
    {
        public string KISITTIPI { get; set; }
        public string KISITKODU { get; set; }
        public int SIRANO { get; set; }
        public string BAGLAC { get; set; }
        public string SAHA { get; set; }
        public string ISLEM { get; set; }
        public string DEGER1 { get; set; }
        public string DEGER2 { get; set; }
    
        public virtual MGKISIT MGKISIT { get; set; }
    }
}
