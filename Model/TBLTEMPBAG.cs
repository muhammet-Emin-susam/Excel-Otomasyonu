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
    
    public partial class TBLTEMPBAG
    {
        public short SUBE_KODU { get; set; }
        public string ADSOY { get; set; }
        public string VERGID { get; set; }
        public string VERGIS { get; set; }
        public string ADRES { get; set; }
        public string DONEM { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
