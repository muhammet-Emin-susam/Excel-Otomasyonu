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
    
    public partial class TBLRCPCONSTRA
    {
        public int RECID { get; set; }
        public string MASID { get; set; }
        public byte CONSID { get; set; }
        public string CONSVALUE { get; set; }
    
        public virtual TBLRCPMAS TBLRCPMAS { get; set; }
    }
}
