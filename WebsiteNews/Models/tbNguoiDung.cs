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
    
    public partial class tbNguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbNguoiDung()
        {
            this.tbTinTucs = new HashSet<tbTinTuc>();
        }
    
        public int MaNguoiDung { get; set; }
        public string TenNguoiDung { get; set; }
        public string EmailNguoiDung { get; set; }
        public string MatKhauNguoiDung { get; set; }
        public string DiaChiNguoiDung { get; set; }
        public Nullable<int> SDTNguoiDung { get; set; }
        public string AnhNguoiDung { get; set; }
        public Nullable<int> SoTinDang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTinTuc> tbTinTucs { get; set; }
    }
}
