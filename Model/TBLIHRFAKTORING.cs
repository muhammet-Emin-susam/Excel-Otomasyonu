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
    
    public partial class TBLIHRFAKTORING
    {
        public string DOSYANO { get; set; }
        public string FATIRS_NO { get; set; }
        public string FTIRSIP { get; set; }
        public string CARI_KOD { get; set; }
        public string EXIMBANK { get; set; }
        public string HESAP_KODU { get; set; }
        public string FORMNO { get; set; }
        public string ODEME_TIPI { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> DEKONTNO { get; set; }
        public string TEMLIKLENDI { get; set; }
        public Nullable<System.DateTime> TEMLIK_TARIHI { get; set; }
        public int INCKEYNO { get; set; }
        public short SUBE_KODU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK1 { get; set; }
        public Nullable<int> I_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
    
        public virtual TBLIHRDOSYAMAS TBLIHRDOSYAMAS { get; set; }
    }
}
