//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GorevYoneticisi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dosyalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dosyalar()
        {
            this.gorev_dosya = new HashSet<gorev_dosya>();
        }
    
        public int id { get; set; }
        public int flag { get; set; }
        public int vid { get; set; }
        public int sort { get; set; }
        public System.DateTime date { get; set; }
        public string isim { get; set; }
        public string aciklama { get; set; }
        public string url { get; set; }
        public int ekleyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gorev_dosya> gorev_dosya { get; set; }
        public virtual kullanicilar kullanicilar { get; set; }
    }
}