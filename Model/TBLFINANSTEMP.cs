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
    
    public partial class TBLFINANSTEMP
    {
        public System.DateTime TARIH { get; set; }
        public byte TIP { get; set; }
        public byte SUBTIP { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<decimal> POZITIF_TUTAR { get; set; }
        public Nullable<decimal> NEGATIF_TUTAR { get; set; }
        public Nullable<byte> DOVIZ_TIPI { get; set; }
        public Nullable<decimal> DOVIZ_TUTAR { get; set; }
        public Nullable<decimal> DEGIS_TUTAR { get; set; }
        public short SUBE_KODU { get; set; }
        public int INCKEYNO { get; set; }
        public int NAKITAKIS_ID { get; set; }
        public Nullable<int> TAHMIN_TIP { get; set; }
        public string TAHMIN_KOD { get; set; }
        public Nullable<short> TAHMIN_DONEM { get; set; }
        public Nullable<short> TAHMIN_YIL { get; set; }
        public string TAHMIN_AKTIF { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
    }
}