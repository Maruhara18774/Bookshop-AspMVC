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
    
    public partial class FEEDBACK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FEEDBACK()
        {
            this.ANHFEEDBACKs = new HashSet<ANHFEEDBACK>();
        }
    
        public int ID_FEEDBACK { get; set; }
        public Nullable<int> ID_SACH { get; set; }
        public Nullable<bool> XACNHAN_MUAHANG { get; set; }
        public Nullable<byte> DIEM_DANHGIA { get; set; }
        public string THOIGIAN_DANG { get; set; }
        public string NOIDUNG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANHFEEDBACK> ANHFEEDBACKs { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
