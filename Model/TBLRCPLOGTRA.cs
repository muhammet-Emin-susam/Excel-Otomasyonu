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
    
    public partial class TBLRCPLOGTRA
    {
        public int RECID { get; set; }
        public string MASID { get; set; }
        public string MACHINENAME { get; set; }
        public string SERVICENAME { get; set; }
        public string NETSISUSERNAME { get; set; }
        public string OSUSERNAME { get; set; }
        public byte TRACEID { get; set; }
        public string TRACEDATA { get; set; }
        public System.DateTime TIMESTAMP { get; set; }
        public Nullable<byte> TRACESTATUS { get; set; }
    
        public virtual TBLRCPMAS TBLRCPMAS { get; set; }
    }
}
