//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XemDSSach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYENMAI()
        {
            this.HINHANHKHUYENMAIs = new HashSet<HINHANHKHUYENMAI>();
            this.SANPHAMKHUYENMAIs = new HashSet<SANPHAMKHUYENMAI>();
        }
    
        public int ID_KHUYENMAI { get; set; }
        public Nullable<int> ID_LOAITK { get; set; }
        public Nullable<int> ID_DIEUKIEN { get; set; }
        public string TEN_KHUYENMAI { get; set; }
        public string THOIGIAN_BATDAU { get; set; }
        public string THOIGIAN_KETTHUC { get; set; }
    
        public virtual DIEUKIENKHUYENMAI DIEUKIENKHUYENMAI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HINHANHKHUYENMAI> HINHANHKHUYENMAIs { get; set; }
        public virtual LOAITAIKHOAN LOAITAIKHOAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAMKHUYENMAI> SANPHAMKHUYENMAIs { get; set; }
    }
}
