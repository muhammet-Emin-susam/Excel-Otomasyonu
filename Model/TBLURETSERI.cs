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
    
    public partial class TBLURETSERI
    {
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public Nullable<int> MAMUL_INCKEY { get; set; }
        public Nullable<int> HAM_INCKEY { get; set; }
        public int INCKEYNO { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
