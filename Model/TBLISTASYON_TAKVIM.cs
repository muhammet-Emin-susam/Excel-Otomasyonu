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
    
    public partial class TBLISTASYON_TAKVIM
    {
        public string ISTKODU { get; set; }
        public System.DateTime TARIH { get; set; }
        public Nullable<decimal> VARDIYASAY { get; set; }
    
        public virtual TBLISTASYON TBLISTASYON { get; set; }
    }
}
