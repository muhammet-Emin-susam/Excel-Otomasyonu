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
    
    public partial class TBLDEPPARAM
    {
        public short SUBE_KODU { get; set; }
        public string SERIFATURADAMI { get; set; }
        public string IRSKAYIT_TUTSUN { get; set; }
        public string URUNHACIMKONTROLU { get; set; }
        public string HUCREMALGRUBUKONT { get; set; }
        public string KAPASITEKONTROLU { get; set; }
        public string BAKIYEZORLANSIN { get; set; }
        public string BRUTNET_TAKIBI { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public string C_YEDEK3 { get; set; }
        public string C_YEDEK4 { get; set; }
        public Nullable<int> I_YEDEK5 { get; set; }
        public Nullable<int> I_YEDEK6 { get; set; }
        public Nullable<decimal> F_YEDEK7 { get; set; }
        public Nullable<decimal> F_YEDEK8 { get; set; }
        public Nullable<System.DateTime> D_YEDEK9 { get; set; }
        public Nullable<System.DateTime> D_YEDEK10 { get; set; }
        public string V_YEDEK11 { get; set; }
        public string V_YEDEK12 { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}
