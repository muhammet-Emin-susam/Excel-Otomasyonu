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
    
    public partial class MGKAMPANYAKISIT
    {
        public string KAMPANYAKOD { get; set; }
        public int URUNNO { get; set; }
        public int KISITNO { get; set; }
        public int BAGLAC { get; set; }
        public int KODTURU { get; set; }
        public int ISLEMTIPI { get; set; }
        public string KOD1 { get; set; }
        public string KOD2 { get; set; }
    
        public virtual MGKAMPANYAURUN MGKAMPANYAURUN { get; set; }
    }
}
