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
    
    public partial class THONGTINKHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGTINKHACHHANG()
        {
            this.DONHANGs = new HashSet<DONHANG>();
            this.HOADONs = new HashSet<HOADON>();
            this.TAIKHOANKHACHHANGs = new HashSet<TAIKHOANKHACHHANG>();
        }
    
        public int ID_TTKH { get; set; }
        public string TEN_KHACHHANG { get; set; }
        public string EMAIL_KHACHHANG { get; set; }
        public string DIACHI { get; set; }
        public string SO_DIENTHOAI { get; set; }
        public Nullable<double> TONG_TIEUDUNG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOANKHACHHANG> TAIKHOANKHACHHANGs { get; set; }
    }
}
