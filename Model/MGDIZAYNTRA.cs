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
    
    public partial class MGDIZAYNTRA
    {
        public int SIRA { get; set; }
        public string DIZAYNKODU { get; set; }
        public byte SAHAKODU { get; set; }
        public byte SATIR { get; set; }
        public byte SUTUN { get; set; }
        public byte UZUNLUK { get; set; }
        public string ACIKLAMA { get; set; }
        public string CONDENSED { get; set; }
        public short SAHAOZELTIP { get; set; }
        public Nullable<short> BASLANGICNO { get; set; }
        public string YAZIILE { get; set; }
    
        public virtual MGDIZAYNMAS MGDIZAYNMAS { get; set; }
    }
}
