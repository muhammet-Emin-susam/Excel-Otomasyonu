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
    
    public partial class TBLBNKTEMTRA
    {
        public string KAYITNO { get; set; }
        public string DEKONTNO { get; set; }
        public Nullable<System.DateTime> BASTARIH { get; set; }
        public Nullable<System.DateTime> BITTARIH { get; set; }
        public string NETHESKODU { get; set; }
        public Nullable<decimal> KOMORAN { get; set; }
        public string KOMMUHKODU { get; set; }
        public Nullable<decimal> KOMTUTAR { get; set; }
        public Nullable<decimal> KOMDOVIZTUTAR { get; set; }
        public string KOMPROJEKODU { get; set; }
        public string KOMMUHREFKOD { get; set; }
        public string DAMGAMUHKODU { get; set; }
        public Nullable<decimal> DAMGATUTAR { get; set; }
        public Nullable<decimal> DAMGADOVIZTUTAR { get; set; }
        public string DAMGAPROJEKODU { get; set; }
        public string DAMGAMUHREFKOD { get; set; }
        public string BSMVMUHKODU { get; set; }
        public Nullable<decimal> BSMVTUTAR { get; set; }
        public Nullable<decimal> BSMVDOVIZTUTAR { get; set; }
        public string BSMVPROJEKODU { get; set; }
        public string BSMVMUHREFKOD { get; set; }
        public int INCKEYNO { get; set; }
        public string TERSKAYIT { get; set; }
        public Nullable<int> TERSINCKEYNO { get; set; }
        public string KAYITYAPANKUL { get; set; }
        public Nullable<System.DateTime> KAYITTARIHI { get; set; }
        public string YEDEK1 { get; set; }
        public string YEDEK2 { get; set; }
        public Nullable<int> YEDEK3 { get; set; }
        public Nullable<int> YEDEK4 { get; set; }
        public Nullable<int> YEDEK5 { get; set; }
        public Nullable<int> YEDEK6 { get; set; }
        public Nullable<decimal> YEDEK7 { get; set; }
        public Nullable<decimal> YEDEK8 { get; set; }
        public Nullable<decimal> YEDEK9 { get; set; }
        public Nullable<decimal> YEDEK10 { get; set; }
        public Nullable<System.DateTime> YEDEK11 { get; set; }
        public Nullable<System.DateTime> YEDEK12 { get; set; }
        public Nullable<System.DateTime> YEDEK13 { get; set; }
        public Nullable<System.DateTime> YEDEK14 { get; set; }
        public string YEDEK15 { get; set; }
        public string YEDEK16 { get; set; }
    
        public virtual TBLBNKHESSABIT TBLBNKHESSABIT { get; set; }
        public virtual TBLBNKTEMSABIT TBLBNKTEMSABIT { get; set; }
        public virtual TBLPROJE TBLPROJE { get; set; }
        public virtual TBLPROJE TBLPROJE1 { get; set; }
        public virtual TBLPROJE TBLPROJE2 { get; set; }
    }
}