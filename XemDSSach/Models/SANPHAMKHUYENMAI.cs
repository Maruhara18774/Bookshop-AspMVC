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
    
    public partial class SANPHAMKHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAMKHUYENMAI()
        {
            this.CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
        }
    
        public int ID_SPKM { get; set; }
        public Nullable<int> ID_SACH { get; set; }
        public Nullable<int> ID_BANGGIA { get; set; }
        public Nullable<double> GIA_GOC { get; set; }
        public Nullable<double> GIA_BAN { get; set; }
        public Nullable<short> SOLUONG { get; set; }
        public Nullable<int> ID_KHUYENMAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual KHUYENMAI KHUYENMAI { get; set; }
    }
}