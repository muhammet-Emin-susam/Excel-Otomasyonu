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
    
    public partial class TBLSTOKBIL
    {
        public string STOK_KODU { get; set; }
        public string BILGI { get; set; }
    
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
    }
}
