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
    
    public partial class TBLISKONTIP
    {
        public short ISLETME_KODU { get; set; }
        public short ISKONTOTIP { get; set; }
        public string ACIKLAMA { get; set; }
        public string MUHASEBEKODU { get; set; }
        public Nullable<System.DateTime> KAYITTAR { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
    }
}
