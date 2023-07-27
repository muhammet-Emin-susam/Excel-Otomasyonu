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
    
    public partial class TBLISTASYON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLISTASYON()
        {
            this.TBLCONFIGTRA = new HashSet<TBLCONFIGTRA>();
            this.TBLESNSTOKURM = new HashSet<TBLESNSTOKURM>();
            this.TBLISEMRIREC = new HashSet<TBLISEMRIREC>();
            this.TBLBILDEG = new HashSet<TBLBILDEG>();
            this.TBLISTASYON_TAKVIM = new HashSet<TBLISTASYON_TAKVIM>();
            this.TBLIUPCZG = new HashSet<TBLIUPCZG>();
            this.TBLMPSKAPASITE = new HashSet<TBLMPSKAPASITE>();
            this.TBLMRPMAKINE = new HashSet<TBLMRPMAKINE>();
            this.TBLOPERATIONS_KATALOG = new HashSet<TBLOPERATIONS_KATALOG>();
            this.TBLOPGECISSURE = new HashSet<TBLOPGECISSURE>();
            this.TBLSTOKURM = new HashSet<TBLSTOKURM>();
            this.TBLSTOKURMALT = new HashSet<TBLSTOKURMALT>();
            this.TBLUAKMAS = new HashSet<TBLUAKMAS>();
        }
    
        public short ISLETME_KODU { get; set; }
        public string ISTKODU { get; set; }
        public string ISTISIM { get; set; }
        public string DEPARTMAN { get; set; }
        public Nullable<decimal> ISCILIK_MAL { get; set; }
        public Nullable<decimal> GENELURETIM_MAL { get; set; }
        public Nullable<decimal> SETUPSURE { get; set; }
        public Nullable<decimal> URETSURE { get; set; }
        public Nullable<decimal> HEDEF_KUYRUK_SURE { get; set; }
        public Nullable<decimal> ORT_KUYRUK_SURE { get; set; }
        public Nullable<decimal> MAX_KUYRUK_SURE { get; set; }
        public Nullable<decimal> MAX_KUYRUK_IZNI { get; set; }
        public Nullable<decimal> STD_VARDIYA1_ESZAMAN_OP { get; set; }
        public Nullable<decimal> MAX_VARDIYA1_ESZAMAN_OP { get; set; }
        public Nullable<decimal> STD_VARDIYA2_ESZAMAN_OP { get; set; }
        public Nullable<decimal> MAX_VARDIYA2_ESZAMAN_OP { get; set; }
        public Nullable<decimal> STD_VARDIYA3_ESZAMAN_OP { get; set; }
        public Nullable<decimal> MAX_VARDIYA3_ESZAMAN_OP { get; set; }
        public Nullable<decimal> STD_VARDIYA4_ESZAMAN_OP { get; set; }
        public Nullable<decimal> MAX_VARDIYA4_ESZAMAN_OP { get; set; }
        public Nullable<System.DateTime> VARDIYA1BAS { get; set; }
        public Nullable<System.DateTime> VARDIYA2BAS { get; set; }
        public Nullable<System.DateTime> VARDIYA3BAS { get; set; }
        public Nullable<System.DateTime> VARDIYA4BAS { get; set; }
        public Nullable<decimal> VARDIYA1SURE { get; set; }
        public Nullable<decimal> VARDIYA2SURE { get; set; }
        public Nullable<decimal> VARDIYA3SURE { get; set; }
        public Nullable<decimal> VARDIYA4SURE { get; set; }
        public string FASONMU { get; set; }
        public string KAPASITE { get; set; }
        public decimal ZAMANSKALASI { get; set; }
        public string MAKINEDETAYLI { get; set; }
        public string CARI_KOD { get; set; }
        public string MAKINE_SECIM_ONCELIGI { get; set; }
        public string ACIKLAMA { get; set; }
        public string AKISTIPLI { get; set; }
        public int AKISTIPLIILKMAKINE_ID { get; set; }
    
        public virtual TBLCASABIT TBLCASABIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCONFIGTRA> TBLCONFIGTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLESNSTOKURM> TBLESNSTOKURM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISEMRIREC> TBLISEMRIREC { get; set; }
        public virtual TBLISLETMELER TBLISLETMELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBILDEG> TBLBILDEG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLISTASYON_TAKVIM> TBLISTASYON_TAKVIM { get; set; }
        public virtual TBLISTASYONEK TBLISTASYONEK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLIUPCZG> TBLIUPCZG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMPSKAPASITE> TBLMPSKAPASITE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLMRPMAKINE> TBLMRPMAKINE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLOPERATIONS_KATALOG> TBLOPERATIONS_KATALOG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLOPGECISSURE> TBLOPGECISSURE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURM> TBLSTOKURM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSTOKURMALT> TBLSTOKURMALT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLUAKMAS> TBLUAKMAS { get; set; }
    }
}