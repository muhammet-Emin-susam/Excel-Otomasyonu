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
    
    public partial class TBLPROFORMAMAS
    {
        public short SUBE_KODU { get; set; }
        public string FTIRSIP { get; set; }
        public string FATIRS_NO { get; set; }
        public string CARI_KODU { get; set; }
        public System.DateTime TARIH { get; set; }
        public Nullable<byte> TIPI { get; set; }
        public Nullable<decimal> BRUTTUTAR { get; set; }
        public Nullable<decimal> SAT_ISKT { get; set; }
        public Nullable<decimal> MFAZ_ISKT { get; set; }
        public Nullable<decimal> GEN_ISK1T { get; set; }
        public Nullable<decimal> GEN_ISK2T { get; set; }
        public Nullable<decimal> GEN_ISK3T { get; set; }
        public Nullable<decimal> GEN_ISK1O { get; set; }
        public Nullable<decimal> GEN_ISK2O { get; set; }
        public Nullable<decimal> GEN_ISK3O { get; set; }
        public Nullable<decimal> KDV { get; set; }
        public Nullable<decimal> FAT_ALTM1 { get; set; }
        public Nullable<decimal> FAT_ALTM2 { get; set; }
        public string ACIKLAMA { get; set; }
        public string KOD1 { get; set; }
        public string KOD2 { get; set; }
        public Nullable<short> ODEMEGUNU { get; set; }
        public Nullable<System.DateTime> ODEMETARIHI { get; set; }
        public string KDV_DAHILMI { get; set; }
        public Nullable<short> FATKALEM_ADEDI { get; set; }
        public Nullable<System.DateTime> SIPARIS_TEST { get; set; }
        public Nullable<decimal> TOPLAM_MIK { get; set; }
        public Nullable<byte> TOPDEPO { get; set; }
        public string YEDEK22 { get; set; }
        public string CARI_KOD2 { get; set; }
        public string YEDEK { get; set; }
        public string UPDATE_KODU { get; set; }
        public int SIRANO { get; set; }
        public Nullable<decimal> KDV_DAHIL_BRUT_TOP { get; set; }
        public Nullable<decimal> KDV_TENZIL { get; set; }
        public Nullable<decimal> MALFAZLASIKDVSI { get; set; }
        public Nullable<decimal> GENELTOPLAM { get; set; }
        public Nullable<decimal> YUVARLAMA { get; set; }
        public string SATIS_KOND { get; set; }
        public string PLA_KODU { get; set; }
        public Nullable<byte> DOVIZTIP { get; set; }
        public Nullable<decimal> DOVIZTUT { get; set; }
        public string KS_KODU { get; set; }
        public Nullable<decimal> BAG_TUTAR { get; set; }
        public string YEDEK2 { get; set; }
        public string HIZMET_FAT { get; set; }
        public Nullable<System.DateTime> VADEBAZT { get; set; }
        public string KAPATILMIS { get; set; }
        public string S_YEDEK1 { get; set; }
        public string S_YEDEK2 { get; set; }
        public Nullable<decimal> F_YEDEK3 { get; set; }
        public Nullable<decimal> F_YEDEK4 { get; set; }
        public Nullable<decimal> F_YEDEK5 { get; set; }
        public string C_YEDEK6 { get; set; }
        public Nullable<byte> B_YEDEK7 { get; set; }
        public Nullable<short> I_YEDEK8 { get; set; }
        public Nullable<int> L_YEDEK9 { get; set; }
        public string AMBAR_KBLNO { get; set; }
        public Nullable<System.DateTime> D_YEDEK10 { get; set; }
        public string PROJE_KODU { get; set; }
        public string KOSULKODU { get; set; }
        public Nullable<System.DateTime> FIYATTARIHI { get; set; }
        public Nullable<System.DateTime> KOSULTARIHI { get; set; }
        public Nullable<short> GENISK1TIP { get; set; }
        public Nullable<short> GENISK2TIP { get; set; }
        public Nullable<short> GENISK3TIP { get; set; }
        public Nullable<byte> EXPORTTYPE { get; set; }
        public string EXGUMRUKNO { get; set; }
        public Nullable<System.DateTime> EXGUMTARIH { get; set; }
        public Nullable<System.DateTime> EXFIILITARIH { get; set; }
        public string EXPORTREFNO { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
        public Nullable<short> GELSUBE_KODU { get; set; }
        public Nullable<short> GITSUBE_KODU { get; set; }
        public string ONAYTIPI { get; set; }
        public int ONAYNUM { get; set; }
        public short ISLETME_KODU { get; set; }
        public string ODEKOD { get; set; }
        public Nullable<decimal> BRMALIYET { get; set; }
        public Nullable<short> KOSVADEGUNU { get; set; }
        public string YAPKOD { get; set; }
        public string GIB_FATIRS_NO { get; set; }
        public string EXTERNALAPPID { get; set; }
        public string EXTERNALREFID { get; set; }
        public Nullable<int> EBELGE { get; set; }
        public Nullable<int> HALFAT { get; set; }
        public Nullable<decimal> FAT_ALTM3 { get; set; }
        public Nullable<System.DateTime> DOVBAZTAR { get; set; }
        public Nullable<decimal> OTVTEVTUTAR { get; set; }
        public Nullable<short> TOPGIRDEPO { get; set; }
        public string BFORM { get; set; }
        public Nullable<int> TEVKIFATIADE { get; set; }
    
        public virtual TBLESNYAPMAS TBLESNYAPMAS { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        public virtual TBLSUBELER TBLSUBELER { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
    }
}
