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
    
    public partial class TBLPOLICEBAGLANTI
    {
        public int INCKEYNO { get; set; }
        public int POLICEMAS_ID { get; set; }
        public string SIRKETKODU { get; set; }
        public string KODU { get; set; }
        public string ISMI { get; set; }
        public string BAGTIPI { get; set; }
    
        public virtual TBLPOLICEMAS TBLPOLICEMAS { get; set; }
        public virtual TBLPOLICEBAGLANTIEK TBLPOLICEBAGLANTIEK { get; set; }
    }
}