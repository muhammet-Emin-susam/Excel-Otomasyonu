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
    
    public partial class TBLSTOK_MADABC
    {
        public int INCKEYNO { get; set; }
        public string STOK_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public Nullable<short> DEPO_KODU { get; set; }
        public Nullable<decimal> MAD { get; set; }
        public string ABC_KODU { get; set; }
        public Nullable<decimal> ASGARI_STOK { get; set; }
        public Nullable<decimal> AZAMI_STOK { get; set; }
        public string YAPKOD { get; set; }
    
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
