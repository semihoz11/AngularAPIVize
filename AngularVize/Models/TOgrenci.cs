//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularVize.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOgrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOgrenci()
        {
            this.TKayit = new HashSet<TKayit>();
        }
    
        public string ogrId { get; set; }
        public string ogrNo { get; set; }
        public string ogrAdsoyad { get; set; }
        public int ogrYas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TKayit> TKayit { get; set; }
    }
}
