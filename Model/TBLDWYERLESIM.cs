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
    
    public partial class TBLDWYERLESIM
    {
        public int INCKEYNO { get; set; }
        public int SEKMEID { get; set; }
        public int GORSELID { get; set; }
        public Nullable<short> SURETIPI { get; set; }
        public Nullable<short> SURE { get; set; }
        public Nullable<int> SIRANO { get; set; }
    
        public virtual TBLDWGORSEL TBLDWGORSEL { get; set; }
        public virtual TBLDWSEKME TBLDWSEKME { get; set; }
    }
}