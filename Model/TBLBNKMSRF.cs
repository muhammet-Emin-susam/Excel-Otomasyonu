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
    
    public partial class TBLBNKMSRF
    {
        public int INCKEYNO { get; set; }
        public string REFERANSNO { get; set; }
        public string MUHREFKOD { get; set; }
        public string MUHKODU { get; set; }
        public string PROJEKODU { get; set; }
        public int BNKKSTINCKEYNO { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<byte> DOVIZTIPI { get; set; }
        public Nullable<decimal> DOVIZTUTARI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string V_YEDEK1 { get; set; }
        public string V_YEDEK2 { get; set; }
    
        public virtual TBLBNKKSTMAS TBLBNKKSTMAS { get; set; }
        public virtual TBLMUPLAN TBLMUPLAN { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
    }
}
