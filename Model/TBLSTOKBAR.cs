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
    
    public partial class TBLSTOKBAR
    {
        public string STOK_KODU { get; set; }
        public string BARKOD { get; set; }
        public string BARTIP { get; set; }
        public Nullable<System.DateTime> BARTARIH { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string S_YEDEK3 { get; set; }
        public string S_YEDEK4 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public string KILIT { get; set; }
        public string YAPKOD { get; set; }
    
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLSTSABIT TBLSTSABIT { get; set; }
    }
}
