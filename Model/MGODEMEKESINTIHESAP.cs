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
    
    public partial class MGODEMEKESINTIHESAP
    {
        public int MGSIRA { get; set; }
        public int ODEMEID { get; set; }
        public string KASAKODU { get; set; }
        public string KESINTITANIM { get; set; }
        public string TIP { get; set; }
        public string KOD { get; set; }
    
        public virtual MGODEME MGODEME { get; set; }
    }
}
