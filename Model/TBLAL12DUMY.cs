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
    
    public partial class TBLAL12DUMY
    {
        public short ISLETME_KODU { get; set; }
        public string DUMY { get; set; }
        public Nullable<decimal> GENELTOPMIK { get; set; }
        public Nullable<decimal> GENELTOPNET { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
    }
}
