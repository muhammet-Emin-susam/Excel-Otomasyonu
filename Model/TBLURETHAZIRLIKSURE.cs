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
    
    public partial class TBLURETHAZIRLIKSURE
    {
        public int INCKEYNO { get; set; }
        public short ISLETME_KODU { get; set; }
        public short SUBE_KODU { get; set; }
        public short OP_DEGER_TIPI { get; set; }
        public string OP_DEGER { get; set; }
        public short MAK_DEGER_TIPI { get; set; }
        public string MAK_DEGER { get; set; }
        public short TANIMTIPI { get; set; }
        public Nullable<short> SOURCE_DEGER_TIPI { get; set; }
        public string SOURCE_DEGER { get; set; }
        public Nullable<short> DEST_DEGER_TIPI { get; set; }
        public string DEST_DEGER { get; set; }
        public string SCRIPT { get; set; }
        public Nullable<decimal> HAZIRLIKSURE { get; set; }
        public string HAZIRLIKSURETIPI { get; set; }
        public Nullable<int> KENDISIDAHIL { get; set; }
        public Nullable<short> DETACHED { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public string C_YEDEK4 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string SOURCE_YAPKOD { get; set; }
        public string DEST_YAPKOD { get; set; }
        public string SADECE_ILK_OPR_ICIN { get; set; }
    
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}