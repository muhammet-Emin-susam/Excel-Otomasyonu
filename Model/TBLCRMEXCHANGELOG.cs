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
    
    public partial class TBLCRMEXCHANGELOG
    {
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public short NETKULID { get; set; }
        public string BASLIK { get; set; }
        public string XMLVERI { get; set; }
        public System.DateTime LOG_ZAMANI { get; set; }
    
        public virtual TBLKULLANP TBLKULLANP { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}