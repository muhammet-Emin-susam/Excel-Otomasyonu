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
    
    public partial class TBLSABLONMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSABLONMAS()
        {
            this.TBLSABLONTRA = new HashSet<TBLSABLONTRA>();
        }
    
        public short SUBE_KODU { get; set; }
        public string SABLON_ADI { get; set; }
        public int INCKEYNO { get; set; }
        public string HAREKET_TURU { get; set; }
        public string ISLEMKES { get; set; }
        public string SIPIRSCREATE { get; set; }
        public string CIKISSIPKONT { get; set; }
        public string DOSWIN { get; set; }
        public string LOGNAME { get; set; }
        public Nullable<byte> STARTROW { get; set; }
        public string TFILENAME { get; set; }
        public string LOGGOSTER { get; set; }
        public string FULLTRAN { get; set; }
        public string SIFRE { get; set; }
        public string IMPORT { get; set; }
        public Nullable<byte> IMEXPORTTYPE { get; set; }
        public string EXPORTWHERE { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<int> YEDEK3 { get; set; }
        public Nullable<int> YEDEK4 { get; set; }
        public Nullable<System.DateTime> YEDEK5 { get; set; }
        public Nullable<System.DateTime> YEDEK6 { get; set; }
        public Nullable<decimal> YEDEK7 { get; set; }
        public Nullable<decimal> YEDEK8 { get; set; }
        public string YEDEK9 { get; set; }
        public string YEDEK10 { get; set; }
        public string BEFORESCRIPT { get; set; }
        public string AFTERSCRIPT { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSABLONTRA> TBLSABLONTRA { get; set; }
    }
}
