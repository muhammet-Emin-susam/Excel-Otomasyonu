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
    
    public partial class TBLMAKBLGNO
    {
        public short SUBE_KODU { get; set; }
        public string SERI { get; set; }
        public string TIP { get; set; }
        public string NUMARA { get; set; }
        public string CYEDEK1 { get; set; }
        public string CYEDEK2 { get; set; }
        public string CYEDEK3 { get; set; }
        public string CYEDEK4 { get; set; }
        public Nullable<int> IYEDEK1 { get; set; }
        public Nullable<int> IYEDEK2 { get; set; }
        public Nullable<decimal> FYEDEK1 { get; set; }
        public Nullable<decimal> FYEDEK2 { get; set; }
        public Nullable<System.DateTime> DYEDEK1 { get; set; }
        public Nullable<System.DateTime> DYEDEK2 { get; set; }
        public string STRYEDEK1 { get; set; }
        public string STRYEDEK2 { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
