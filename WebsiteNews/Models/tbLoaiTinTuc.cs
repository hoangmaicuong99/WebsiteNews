//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteNews.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbLoaiTinTuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbLoaiTinTuc()
        {
            this.tbTinTucs = new HashSet<tbTinTuc>();
        }
    
        public int MaLoaiTinTuc { get; set; }
        public string TenLoaiTin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTinTuc> tbTinTucs { get; set; }
    }
}