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
    
    public partial class TBLKRTTHSLTEK
    {
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public int KRTTHSLTINCKEYNO { get; set; }
        public int BNKHESTRAINCKEYNO { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<int> YEDEK3 { get; set; }
        public Nullable<int> YEDEK4 { get; set; }
        public Nullable<int> YEDEK5 { get; set; }
        public Nullable<int> YEDEK6 { get; set; }
        public Nullable<decimal> YEDEK7 { get; set; }
        public Nullable<decimal> YEDEK8 { get; set; }
        public Nullable<decimal> YEDEK9 { get; set; }
        public Nullable<decimal> YEDEK10 { get; set; }
        public Nullable<System.DateTime> YEDEK11 { get; set; }
        public Nullable<System.DateTime> YEDEK12 { get; set; }
        public Nullable<System.DateTime> YEDEK13 { get; set; }
        public Nullable<System.DateTime> YEDEK14 { get; set; }
        public string YEDEK15 { get; set; }
        public string YEDEK16 { get; set; }
    
        public virtual TBLKRTTHSLT TBLKRTTHSLT { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
