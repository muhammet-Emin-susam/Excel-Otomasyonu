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
    
    public partial class TBLBNKONLOTMODEME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLBNKONLOTMODEME()
        {
            this.TBLBNKONLOTMTRANS = new HashSet<TBLBNKONLOTMTRANS>();
        }
    
        public short SUBE_KODU { get; set; }
        public string BANKAKODU { get; set; }
        public string KURUM { get; set; }
        public string ABONENO { get; set; }
        public string ACIKLAMA { get; set; }
        public string CARIMUHKODU { get; set; }
        public string C_M { get; set; }
        public string PROJEKODU { get; set; }
        public string ONODEMELI { get; set; }
        public string ONCARIMUHKODU { get; set; }
        public string ONC_M { get; set; }
        public string ONPROJEKODU { get; set; }
        public string GIDERHESKODU { get; set; }
        public string KDVHESKODU { get; set; }
        public string GIDERPROJEKOD { get; set; }
        public string GIDERREFKOD { get; set; }
        public string OZILETHESKOD { get; set; }
        public string OZILETPROJEKOD { get; set; }
        public string OZILETREFKOD { get; set; }
        public string OZISLEMHESKOD { get; set; }
        public string OZISLEMPROJEKOD { get; set; }
        public string OZISLEMREFKOD { get; set; }
        public string FARKHESKOD { get; set; }
        public string FARKPROJEKOD { get; set; }
        public string FARKREFKOD { get; set; }
        public string PLASIYERKOD { get; set; }
        public string DEKONTSERI { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public Nullable<System.DateTime> D_YEDEK1 { get; set; }
        public Nullable<System.DateTime> D_YEDEK2 { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
    
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBNKONLOTMTRANS> TBLBNKONLOTMTRANS { get; set; }
    }
}
