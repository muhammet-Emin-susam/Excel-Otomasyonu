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
    
    public partial class TBLISEMRIEK
    {
        public string ISEMRI { get; set; }
        public string KT_PLAN_HAFTA { get; set; }
        public string KT_IML_DURUM { get; set; }
    
        public virtual TBLISEMRI TBLISEMRI { get; set; }
    }
}
