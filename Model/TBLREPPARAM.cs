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
    
    public partial class TBLREPPARAM
    {
        public short ISLETME_KODU { get; set; }
        public string ONCEKI_DATABASE { get; set; }
        public Nullable<short> FIYAT { get; set; }
        public Nullable<short> YAR_GERI_GUN { get; set; }
        public Nullable<short> HES_GERI_GUN { get; set; }
        public Nullable<short> BOLEN { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
    }
}
