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
    
    public partial class TBLRCAJMPOOL
    {
        public int JOBID { get; set; }
        public string BLLNAME { get; set; }
        public byte LG_PACKAGE { get; set; }
        public string LG_USERNAME { get; set; }
        public int LG_USERID { get; set; }
        public int LG_USERGRID { get; set; }
        public string LOGINDETAIL { get; set; }
        public string INPUTDATA { get; set; }
        public string RECURRENCEINFO { get; set; }
        public byte SCHEDULETYPE { get; set; }
        public System.DateTime STARTDATETIME { get; set; }
        public System.DateTime EXPIREDATETIME { get; set; }
        public string JOBSEXECUTED { get; set; }
        public string JOBSFAILED { get; set; }
        public byte COMPLETED { get; set; }
    }
}
