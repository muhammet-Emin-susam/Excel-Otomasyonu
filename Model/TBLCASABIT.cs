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
    
    public partial class TBLCASABIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCASABIT()
        {
            this.TBLBAGLANTI = new HashSet<TBLBAGLANTI>();
            this.TBLBKMSOZMAS = new HashSet<TBLBKMSOZMAS>();
            this.TBLBNKSCENTEGREMAS = new HashSet<TBLBNKSCENTEGREMAS>();
            this.TBLBNKTEMSABIT = new HashSet<TBLBNKTEMSABIT>();
            this.TBLCAGRUP2 = new HashSet<TBLCAGRUP2>();
            this.TBLCAHAR = new HashSet<TBLCAHAR>();
            this.TBLCARIBARKOD = new HashSet<TBLCARIBARKOD>();
            this.TBLCARIEMAIL = new HashSet<TBLCARIEMAIL>();
            this.TBLCARIIHRINFO1 = new HashSet<TBLCARIIHRINFO>();
            this.TBLCARIIHRINFO2 = new HashSet<TBLCARIIHRINFO>();
            this.TBLCARIIHRINFO3 = new HashSet<TBLCARIIHRINFO>();
            this.TBLCARIIHRINFO4 = new HashSet<TBLCARIIHRINFO>();
            this.TBLCARIIHRINFO5 = new HashSet<TBLCARIIHRINFO>();
            this.TBLCARIIHRSOZLESME = new HashSet<TBLCARIIHRSOZLESME>();
            this.TBLCARISTOK = new HashSet<TBLCARISTOK>();
            this.TBLDAMGAVERGISI = new HashSet<TBLDAMGAVERGISI>();
            this.TBLCABNKSABIT = new HashSet<TBLCABNKSABIT>();
            this.TBLCRMANKCEVAPMAS = new HashSet<TBLCRMANKCEVAPMAS>();
            this.TBLCRMSATAKT = new HashSet<TBLCRMSATAKT>();
            this.TBLCRMSKYSABIT = new HashSet<TBLCRMSKYSABIT>();
            this.TBLDBSFATURAMAS = new HashSet<TBLDBSFATURAMAS>();
            this.TBLDBSLIMITRISK = new HashSet<TBLDBSLIMITRISK>();
            this.TBLEMUTABAKATTRA = new HashSet<TBLEMUTABAKATTRA>();
            this.TBLFARKLITESLIM = new HashSet<TBLFARKLITESLIM>();
            this.TBLHIZMETMALIYETMAS = new HashSet<TBLHIZMETMALIYETMAS>();
            this.TBLIHRDOSYAMAS = new HashSet<TBLIHRDOSYAMAS>();
            this.TBLIHRGUMRUKBEYANNAME = new HashSet<TBLIHRGUMRUKBEYANNAME>();
            this.TBLIHRKASE = new HashSet<TBLIHRKASE>();
            this.TBLIHRNAKLIYETRA = new HashSet<TBLIHRNAKLIYETRA>();
            this.TBLIHRNAKLIYETRA1 = new HashSet<TBLIHRNAKLIYETRA>();
            this.TBLIHRNAKLIYETRA2 = new HashSet<TBLIHRNAKLIYETRA>();
            this.TBLIHRNAKLIYETRA3 = new HashSet<TBLIHRNAKLIYETRA>();
            this.TBLIHRNAKLIYETRA4 = new HashSet<TBLIHRNAKLIYETRA>();
            this.TBLISTASYON = new HashSet<TBLISTASYON>();
            this.TBLITHDOSYAMAS = new HashSet<TBLITHDOSYAMAS>();
            this.TBLITHGUMRUKBEYANNAME = new HashSet<TBLITHGUMRUKBEYANNAME>();
            this.TBLIUPCZG = new HashSet<TBLIUPCZG>();
            this.TBLIUPCZGDTY = new HashSet<TBLIUPCZGDTY>();
            this.TBLIUPSIP = new HashSet<TBLIUPSIP>();
            this.TBLIUPSIP1 = new HashSet<TBLIUPSIP>();
            this.TBLIUPSIP2 = new HashSet<TBLIUPSIP>();
            this.TBLKAMYONSB = new HashSet<TBLKAMYONSB>();
            this.TBLKEFILTRA = new HashSet<TBLKEFILTRA>();
            this.TBLKEFILTRA1 = new HashSet<TBLKEFILTRA>();
            this.TBLKKCARISTOK = new HashSet<TBLKKCARISTOK>();
            this.TBLKKCARISTOKMUAYENE = new HashSet<TBLKKCARISTOKMUAYENE>();
            this.TBLMAGAZALAR = new HashSet<TBLMAGAZALAR>();
            this.TBLMAGAZALAR1 = new HashSet<TBLMAGAZALAR>();
            this.TBLMASRAFTRA = new HashSet<TBLMASRAFTRA>();
            this.TBLMASRAFTRA1 = new HashSet<TBLMASRAFTRA>();
            this.TBLMRPISCI = new HashSet<TBLMRPISCI>();
            this.TBLMRPMAKINE = new HashSet<TBLMRPMAKINE>();
            this.TBLNAKLIYE = new HashSet<TBLNAKLIYE>();
            this.TBLPLANLAMA_RAPORU_DETAY = new HashSet<TBLPLANLAMA_RAPORU_DETAY>();
            this.TBLTARTIMBLG = new HashSet<TBLTARTIMBLG>();
            this.TBLTMPBNKSCENTEGREMAS = new HashSet<TBLTMPBNKSCENTEGREMAS>();
            this.TBLTMPDBSFATURAMAS = new HashSet<TBLTMPDBSFATURAMAS>();
            this.TBLTMPDBSLIMITRISK = new HashSet<TBLTMPDBSLIMITRISK>();
        }
    
        public short SUBE_KODU { get; set; }
        public short ISLETME_KODU { get; set; }
        public string CARI_KOD { get; set; }
        public string CARI_TEL { get; set; }
        public string CARI_IL { get; set; }
        public string ULKE_KODU { get; set; }
        public string CARI_ISIM { get; set; }
        public string CARI_TIP { get; set; }
        public string GRUP_KODU { get; set; }
        public string RAPOR_KODU1 { get; set; }
        public string RAPOR_KODU2 { get; set; }
        public string RAPOR_KODU3 { get; set; }
        public string RAPOR_KODU4 { get; set; }
        public string RAPOR_KODU5 { get; set; }
        public string CARI_ADRES { get; set; }
        public string CARI_ILCE { get; set; }
        public string VERGI_DAIRESI { get; set; }
        public string VERGI_NUMARASI { get; set; }
        public string FAX { get; set; }
        public string POSTAKODU { get; set; }
        public Nullable<short> DETAY_KODU { get; set; }
        public Nullable<decimal> NAKLIYE_KATSAYISI { get; set; }
        public Nullable<decimal> RISK_SINIRI { get; set; }
        public Nullable<decimal> TEMINATI { get; set; }
        public Nullable<decimal> CARISK { get; set; }
        public Nullable<decimal> CCRISK { get; set; }
        public Nullable<decimal> SARISK { get; set; }
        public Nullable<decimal> SCRISK { get; set; }
        public Nullable<decimal> CM_BORCT { get; set; }
        public Nullable<decimal> CM_ALACT { get; set; }
        public Nullable<System.DateTime> CM_RAP_TARIH { get; set; }
        public string KOSULKODU { get; set; }
        public Nullable<decimal> ISKONTO_ORANI { get; set; }
        public Nullable<short> VADE_GUNU { get; set; }
        public Nullable<byte> LISTE_FIATI { get; set; }
        public string ACIK1 { get; set; }
        public string ACIK2 { get; set; }
        public string ACIK3 { get; set; }
        public string M_KOD { get; set; }
        public Nullable<byte> DOVIZ_TIPI { get; set; }
        public Nullable<byte> DOVIZ_TURU { get; set; }
        public string HESAPTUTMASEKLI { get; set; }
        public string DOVIZLIMI { get; set; }
        public string UPDATE_KODU { get; set; }
        public string PLASIYER_KODU { get; set; }
        public Nullable<short> LOKALDEPO { get; set; }
        public string EMAIL { get; set; }
        public string WEB { get; set; }
        public string KURFARKIBORC { get; set; }
        public string KURFARKIALAC { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK1 { get; set; }
        public Nullable<decimal> F_YEDEK2 { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public Nullable<byte> B_YEDEK1 { get; set; }
        public Nullable<short> I_YEDEK1 { get; set; }
        public Nullable<int> L_YEDEK1 { get; set; }
        public string FIYATGRUBU { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<byte> ODEMETIPI { get; set; }
        public string ONAYTIPI { get; set; }
        public Nullable<int> ONAYNUM { get; set; }
        public string MUSTERIBAZIKDV { get; set; }
        public Nullable<decimal> AGIRLIK_ISK { get; set; }
        public string CARI_TEL2 { get; set; }
        public string CARI_TEL3 { get; set; }
        public string FAX2 { get; set; }
        public string GSM1 { get; set; }
        public string GSM2 { get; set; }
        public string GEKAPHESAPLANMASIN { get; set; }
        public string ONCEKI_KOD { get; set; }
        public string SONRAKI_KOD { get; set; }
        public string SONCARIKODU { get; set; }
        public string TESLIMCARIBAGLIMI { get; set; }
        public string BAGLICARIKOD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBAGLANTI> TBLBAGLANTI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBKMSOZMAS> TBLBKMSOZMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBNKSCENTEGREMAS> TBLBNKSCENTEGREMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBNKTEMSABIT> TBLBNKTEMSABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCAGRUP2> TBLCAGRUP2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCAHAR> TBLCAHAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIBARKOD> TBLCARIBARKOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIEMAIL> TBLCARIEMAIL { get; set; }
        public virtual TBLCARIGORUNURLUK TBLCARIGORUNURLUK { get; set; }
        public virtual TBLCARIIHRINFO TBLCARIIHRINFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIIHRINFO> TBLCARIIHRINFO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIIHRINFO> TBLCARIIHRINFO2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIIHRINFO> TBLCARIIHRINFO3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIIHRINFO> TBLCARIIHRINFO4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIIHRINFO> TBLCARIIHRINFO5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIIHRSOZLESME> TBLCARIIHRSOZLESME { get; set; }
        public virtual TBLCARIMEKTUP TBLCARIMEKTUP { get; set; }
        public virtual TBLCARISAHATABLOESLEME TBLCARISAHATABLOESLEME { get; set; }
        public virtual TBLCARISK TBLCARISK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARISTOK> TBLCARISTOK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDAMGAVERGISI> TBLDAMGAVERGISI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCABNKSABIT> TBLCABNKSABIT { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLCASABITEK TBLCASABITEK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMANKCEVAPMAS> TBLCRMANKCEVAPMAS { get; set; }
        public virtual TBLCRMCASABIT TBLCRMCASABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMSATAKT> TBLCRMSATAKT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCRMSKYSABIT> TBLCRMSKYSABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDBSFATURAMAS> TBLDBSFATURAMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDBSLIMITRISK> TBLDBSLIMITRISK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLEMUTABAKATTRA> TBLEMUTABAKATTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFARKLITESLIM> TBLFARKLITESLIM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLHIZMETMALIYETMAS> TBLHIZMETMALIYETMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRDOSYAMAS> TBLIHRDOSYAMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRGUMRUKBEYANNAME> TBLIHRGUMRUKBEYANNAME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRKASE> TBLIHRKASE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRNAKLIYETRA> TBLIHRNAKLIYETRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRNAKLIYETRA> TBLIHRNAKLIYETRA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRNAKLIYETRA> TBLIHRNAKLIYETRA2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRNAKLIYETRA> TBLIHRNAKLIYETRA3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIHRNAKLIYETRA> TBLIHRNAKLIYETRA4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISTASYON> TBLISTASYON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLITHDOSYAMAS> TBLITHDOSYAMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLITHGUMRUKBEYANNAME> TBLITHGUMRUKBEYANNAME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZG> TBLIUPCZG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZGDTY> TBLIUPCZGDTY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPSIP> TBLIUPSIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPSIP> TBLIUPSIP1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPSIP> TBLIUPSIP2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKAMYONSB> TBLKAMYONSB { get; set; }
        public virtual TBLKEFILSABIT TBLKEFILSABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKEFILTRA> TBLKEFILTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKEFILTRA> TBLKEFILTRA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKKCARISTOK> TBLKKCARISTOK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKKCARISTOKMUAYENE> TBLKKCARISTOKMUAYENE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMAGAZALAR> TBLMAGAZALAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMAGAZALAR> TBLMAGAZALAR1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMASRAFTRA> TBLMASRAFTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMASRAFTRA> TBLMASRAFTRA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMRPISCI> TBLMRPISCI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMRPMAKINE> TBLMRPMAKINE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLNAKLIYE> TBLNAKLIYE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPLANLAMA_RAPORU_DETAY> TBLPLANLAMA_RAPORU_DETAY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTARTIMBLG> TBLTARTIMBLG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTMPBNKSCENTEGREMAS> TBLTMPBNKSCENTEGREMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTMPDBSFATURAMAS> TBLTMPDBSFATURAMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTMPDBSLIMITRISK> TBLTMPDBSLIMITRISK { get; set; }
    }
}
