//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gorselfinali
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zimmet
    {
        public int zimmetID { get; set; }
        public Nullable<int> personelID { get; set; }
        public string zimmetler { get; set; }
        public string personelTCNO { get; set; }
        public Nullable<System.DateTime> eklenmeTarihi { get; set; }
    
        public virtual Personel Personel { get; set; }
    }
}
