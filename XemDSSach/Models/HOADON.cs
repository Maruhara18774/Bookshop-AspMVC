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
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }
    
        public int ID_HOADON { get; set; }
        public Nullable<int> ID_TTKH { get; set; }
        public Nullable<int> ID_TRANGTHAI { get; set; }
        public Nullable<double> TONGTIEN { get; set; }
        public Nullable<int> ID_DONHANG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DONHANG DONHANG { get; set; }
        public virtual TRANGTHAIDONHANG TRANGTHAIDONHANG { get; set; }
        public virtual THONGTINKHACHHANG THONGTINKHACHHANG { get; set; }
    }
}