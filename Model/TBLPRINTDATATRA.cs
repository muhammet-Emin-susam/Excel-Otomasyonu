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
    
    public partial class TBLPRINTDATATRA
    {
        public int INCKEYNO { get; set; }
        public int MASTERINCKEYNO { get; set; }
        public string PRINTDATA { get; set; }
        public string CYEDEK1 { get; set; }
        public string CYEDEK2 { get; set; }
        public Nullable<int> IYEDEK1 { get; set; }
        public Nullable<int> IYEDEK2 { get; set; }
        public Nullable<int> IYEDEK3 { get; set; }
        public Nullable<int> IYEDEK4 { get; set; }
        public Nullable<double> FYEDEK1 { get; set; }
        public Nullable<double> FYEDEK2 { get; set; }
        public Nullable<double> FYEDEK3 { get; set; }
        public Nullable<double> FYEDEK4 { get; set; }
        public Nullable<System.DateTime> DYEDEK1 { get; set; }
        public Nullable<System.DateTime> DYEDEK2 { get; set; }
        public Nullable<System.DateTime> DYEDEK3 { get; set; }
        public Nullable<System.DateTime> DYEDEK4 { get; set; }
    
        public virtual TBLPRINTDATAMASTER TBLPRINTDATAMASTER { get; set; }
    }
}
