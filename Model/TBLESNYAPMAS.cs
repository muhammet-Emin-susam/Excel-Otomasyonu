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
    
    public partial class TBLESNYAPMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLESNYAPMAS()
        {
            this.TBLCARISTOK = new HashSet<TBLCARISTOK>();
            this.TBLDEPHAR = new HashSet<TBLDEPHAR>();
            this.TBLDEPSAYIM = new HashSet<TBLDEPSAYIM>();
            this.TBLESNSTOKURM = new HashSet<TBLESNSTOKURM>();
            this.TBLBCK_MRP_DETAIL = new HashSet<TBLBCK_MRP_DETAIL>();
            this.TBLBCK_MRP_DETAIL1 = new HashSet<TBLBCK_MRP_DETAIL>();
            this.TBLBCK_MRP_DETAIL2 = new HashSet<TBLBCK_MRP_DETAIL>();
            this.TBLBCK_MRPPLAN = new HashSet<TBLBCK_MRPPLAN>();
            this.TBLBCK_MRPSIP = new HashSet<TBLBCK_MRPSIP>();
            this.TBLBCK_MRPSIP1 = new HashSet<TBLBCK_MRPSIP>();
            this.TBLBCK_MRP = new HashSet<TBLBCK_MRP>();
            this.TBLDEPDURUM = new HashSet<TBLDEPDURUM>();
            this.TBLESNSTMAS = new HashSet<TBLESNSTMAS>();
            this.TBLESNYAPMAS1 = new HashSet<TBLESNYAPMAS>();
            this.TBLESNYAPTRA = new HashSet<TBLESNYAPTRA>();
            this.TBLFATUIRS = new HashSet<TBLFATUIRS>();
            this.TBLFORECAST = new HashSet<TBLFORECAST>();
            this.TBLISEMRIREC = new HashSet<TBLISEMRIREC>();
            this.TBLISEMRIREC1 = new HashSet<TBLISEMRIREC>();
            this.TBLISEMRIREC2 = new HashSet<TBLISEMRIREC>();
            this.TBLISEMRI = new HashSet<TBLISEMRI>();
            this.TBLISEMRI1 = new HashSet<TBLISEMRI>();
            this.TBLIUPCZG = new HashSet<TBLIUPCZG>();
            this.TBLIUPCZGSTK = new HashSet<TBLIUPCZGSTK>();
            this.TBLIUPCZGSTK1 = new HashSet<TBLIUPCZGSTK>();
            this.TBLIUPHATA = new HashSet<TBLIUPHATA>();
            this.TBLIUPSIP = new HashSet<TBLIUPSIP>();
            this.TBLIUPSIP1 = new HashSet<TBLIUPSIP>();
            this.TBLIUPSTKGBKY = new HashSet<TBLIUPSTKGBKY>();
            this.TBLKAPASITE = new HashSet<TBLKAPASITE>();
            this.TBLMPS = new HashSet<TBLMPS>();
            this.TBLMRPPLAN = new HashSet<TBLMRPPLAN>();
            this.TBLMRPSIP = new HashSet<TBLMRPSIP>();
            this.TBLMRPSIP1 = new HashSet<TBLMRPSIP>();
            this.TBLMRP = new HashSet<TBLMRP>();
            this.TBLPOSKUMULE = new HashSet<TBLPOSKUMULE>();
            this.TBLPROFORMAMAS = new HashSet<TBLPROFORMAMAS>();
            this.TBLPROFORMATRA = new HashSet<TBLPROFORMATRA>();
            this.TBLPROFORMATRA1 = new HashSet<TBLPROFORMATRA>();
            this.TBLRECMALIYET = new HashSet<TBLRECMALIYET>();
            this.TBLRECMALIYET1 = new HashSet<TBLRECMALIYET>();
            this.TBLREPLANISH = new HashSet<TBLREPLANISH>();
            this.TBLSAYIM = new HashSet<TBLSAYIM>();
            this.TBLSEVKTRA = new HashSet<TBLSEVKTRA>();
            this.TBLSIPAMAS = new HashSet<TBLSIPAMAS>();
            this.TBLSIPATRA = new HashSet<TBLSIPATRA>();
            this.TBLSIPATRA1 = new HashSet<TBLSIPATRA>();
            this.TBLSIPTEMP = new HashSet<TBLSIPTEMP>();
            this.TBLSIPTTOP = new HashSet<TBLSIPTTOP>();
            this.TBLSTHAR = new HashSet<TBLSTHAR>();
            this.TBLSTHAR1 = new HashSet<TBLSTHAR>();
            this.TBLSTOK_MADABC = new HashSet<TBLSTOK_MADABC>();
            this.TBLPOSTEMP = new HashSet<TBLPOSTEMP>();
            this.TBLSTOKBAR = new HashSet<TBLSTOKBAR>();
            this.TBLSTOKKOLI = new HashSet<TBLSTOKKOLI>();
            this.TBLSTOKKOLI1 = new HashSet<TBLSTOKKOLI>();
            this.TBLSTOKMALIYET = new HashSet<TBLSTOKMALIYET>();
            this.TBLSTOKPH = new HashSet<TBLSTOKPH>();
            this.TBLSTOKURM = new HashSet<TBLSTOKURM>();
            this.TBLSTOKURM1 = new HashSet<TBLSTOKURM>();
            this.TBLSTOKURM2 = new HashSet<TBLSTOKURM>();
            this.TBLSTOKURMALT = new HashSet<TBLSTOKURMALT>();
            this.TBLSTOKURMALT1 = new HashSet<TBLSTOKURMALT>();
            this.TBLSTOKURMALT2 = new HashSet<TBLSTOKURMALT>();
            this.TBLSTOKURS = new HashSet<TBLSTOKURS>();
            this.TBLSTSABIT = new HashSet<TBLSTSABIT>();
            this.TBLTEKLIFMAS = new HashSet<TBLTEKLIFMAS>();
            this.TBLTEKLIFTRA = new HashSet<TBLTEKLIFTRA>();
            this.TBLTEKLIFTRA1 = new HashSet<TBLTEKLIFTRA>();
        }
    
        public short ISLETME_KODU { get; set; }
        public string YAPKOD { get; set; }
        public string YAPACIK { get; set; }
        public string REVIZYAPKOD { get; set; }
        public string YPLNDRSTOKKOD { get; set; }
        public Nullable<System.DateTime> GECBASTAR { get; set; }
        public Nullable<System.DateTime> GECBITTAR { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string DUZELTMEYAPANKUL { get; set; }
        public Nullable<System.DateTime> DUZELTMETARIHI { get; set; }
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
        public short SUBE_KODU { get; set; }
        public Nullable<decimal> BIRIM_MALIYET { get; set; }
        public Nullable<decimal> CURBIRIM_MALIYET { get; set; }
        public string ONCEKI_KOD { get; set; }
        public string SONRAKI_KOD { get; set; }
        public string SONYAPKOD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARISTOK> TBLCARISTOK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDEPHAR> TBLDEPHAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDEPSAYIM> TBLDEPSAYIM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLESNSTOKURM> TBLESNSTOKURM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBCK_MRP_DETAIL> TBLBCK_MRP_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBCK_MRP_DETAIL> TBLBCK_MRP_DETAIL1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBCK_MRP_DETAIL> TBLBCK_MRP_DETAIL2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBCK_MRPPLAN> TBLBCK_MRPPLAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBCK_MRPSIP> TBLBCK_MRPSIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBCK_MRPSIP> TBLBCK_MRPSIP1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBCK_MRP> TBLBCK_MRP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDEPDURUM> TBLDEPDURUM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLESNSTMAS> TBLESNSTMAS { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLESNYAPMAS> TBLESNYAPMAS1 { get; set; }
        public virtual TBLESNYAPMAS TBLESNYAPMAS2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLESNYAPTRA> TBLESNYAPTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFATUIRS> TBLFATUIRS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFORECAST> TBLFORECAST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISEMRIREC> TBLISEMRIREC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISEMRIREC> TBLISEMRIREC1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISEMRIREC> TBLISEMRIREC2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISEMRI> TBLISEMRI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISEMRI> TBLISEMRI1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZG> TBLIUPCZG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZGSTK> TBLIUPCZGSTK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZGSTK> TBLIUPCZGSTK1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPHATA> TBLIUPHATA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPSIP> TBLIUPSIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPSIP> TBLIUPSIP1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPSTKGBKY> TBLIUPSTKGBKY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKAPASITE> TBLKAPASITE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMPS> TBLMPS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMRPPLAN> TBLMRPPLAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMRPSIP> TBLMRPSIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMRPSIP> TBLMRPSIP1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMRP> TBLMRP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPOSKUMULE> TBLPOSKUMULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPROFORMAMAS> TBLPROFORMAMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPROFORMATRA> TBLPROFORMATRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPROFORMATRA> TBLPROFORMATRA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLRECMALIYET> TBLRECMALIYET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLRECMALIYET> TBLRECMALIYET1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLREPLANISH> TBLREPLANISH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSAYIM> TBLSAYIM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSEVKTRA> TBLSEVKTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSIPAMAS> TBLSIPAMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSIPATRA> TBLSIPATRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSIPATRA> TBLSIPATRA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSIPTEMP> TBLSIPTEMP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSIPTTOP> TBLSIPTTOP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTHAR> TBLSTHAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTHAR> TBLSTHAR1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOK_MADABC> TBLSTOK_MADABC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPOSTEMP> TBLPOSTEMP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKBAR> TBLSTOKBAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKKOLI> TBLSTOKKOLI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKKOLI> TBLSTOKKOLI1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKMALIYET> TBLSTOKMALIYET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKPH> TBLSTOKPH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURM> TBLSTOKURM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURM> TBLSTOKURM1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURM> TBLSTOKURM2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURMALT> TBLSTOKURMALT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURMALT> TBLSTOKURMALT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURMALT> TBLSTOKURMALT2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURS> TBLSTOKURS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTSABIT> TBLSTSABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTEKLIFMAS> TBLTEKLIFMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTEKLIFTRA> TBLTEKLIFTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTEKLIFTRA> TBLTEKLIFTRA1 { get; set; }
    }
}
