//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MusteriFirma
    {
        public MusteriFirma()
        {
            this.FaaliyetAlanis = new HashSet<FaaliyetAlani>();
        }
    
        public string Mersis { get; set; }
        public string Unvan { get; set; }
        public int MusteriID { get; set; }
    
        public virtual Musteri Musteri { get; set; }
        public virtual ICollection<FaaliyetAlani> FaaliyetAlanis { get; set; }
    }
}
