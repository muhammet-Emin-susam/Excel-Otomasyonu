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
    
    public partial class MGASORTIDETAY
    {
        public int ASDETAYID { get; set; }
        public string ASKOD { get; set; }
        public string OZEL1KOD { get; set; }
        public string OZEL2KOD { get; set; }
        public string OZEL3KOD { get; set; }
        public string OZEL4KOD { get; set; }
        public string OZEL5KOD { get; set; }
        public int MIKTAR { get; set; }
    
        public virtual MGASORTI MGASORTI { get; set; }
    }
}
