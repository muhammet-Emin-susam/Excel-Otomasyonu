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
    
    public partial class TBLNAKLIYE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLNAKLIYE()
        {
            this.TBLNAKLIYEBELGELINK = new HashSet<TBLNAKLIYEBELGELINK>();
        }
    
        public string NAKLIYENO { get; set; }
        public string GIRISCIKIS { get; set; }
        public Nullable<System.DateTime> NAKLIYETARIHI { get; set; }
        public string ARACKODU { get; set; }
        public string PLAKANO { get; set; }
        public string SOFOR { get; set; }
        public string NAKCARKOD { get; set; }
        public string ACIKLAMA { get; set; }
        public string NAKLIYETIPI { get; set; }
        public Nullable<decimal> TOPLAMMESAFE { get; set; }
        public Nullable<decimal> TOPLAMAGIRLIK { get; set; }
        public Nullable<decimal> BIRIMMALIYET { get; set; }
        public Nullable<decimal> TASIMABRUTMALIYET { get; set; }
        public Nullable<decimal> TASIMANETMALIYET { get; set; }
        public Nullable<decimal> EKMALIYET1 { get; set; }
        public string EKMALIYETACK1 { get; set; }
        public Nullable<decimal> EKMALIYET2 { get; set; }
        public string EKMALIYETACK2 { get; set; }
        public Nullable<decimal> EKMALIYET3 { get; set; }
        public string EKMALIYETACK3 { get; set; }
        public Nullable<decimal> EKMALIYET4 { get; set; }
        public string EKMALIYETACK4 { get; set; }
        public string NAKFATNO { get; set; }
        public Nullable<decimal> TOPLAMMALIYET { get; set; }
        public Nullable<short> SUBE_KODU { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> I_YEDEK3 { get; set; }
        public Nullable<int> I_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK5 { get; set; }
        public Nullable<decimal> F_YEDEK6 { get; set; }
        public Nullable<System.DateTime> D_YEDEK7 { get; set; }
        public Nullable<System.DateTime> D_YEDEK8 { get; set; }
        public string V_YEDEK10 { get; set; }
        public string V_YEDEK11 { get; set; }
        public Nullable<byte> DOVTIP { get; set; }
        public Nullable<decimal> TOPLAMDOVMALIYET { get; set; }
        public string ENTEGREFKEY { get; set; }
        public string NEREDEN_IL { get; set; }
        public string NEREDEN_ILCE { get; set; }
        public string NEREYE_IL { get; set; }
        public string NEREYE_ILCE { get; set; }
        public string TASTEV_KOD { get; set; }
        public string EXMAL1TEV_KOD { get; set; }
        public string EXMAL2TEV_KOD { get; set; }
        public string EXMAL3TEV_KOD { get; set; }
        public string EXMAL4TEV_KOD { get; set; }
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLNAKLIYEBELGELINK> TBLNAKLIYEBELGELINK { get; set; }
    }
}
