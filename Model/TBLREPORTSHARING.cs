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
    
    public partial class TBLREPORTSHARING
    {
        public long SHARING_ID { get; set; }
        public int REPORT_ID { get; set; }
        public short SUBE_KODU { get; set; }
        public short USER_ID { get; set; }
        public string CANCOMMENT { get; set; }
        public string CANDELETE { get; set; }
        public System.DateTime TIMESTAMP { get; set; }
    
        public virtual TBLREPORTING TBLREPORTING { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}