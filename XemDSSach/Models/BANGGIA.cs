﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;

    public partial class BANGGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGGIA()
        {
            this.CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
            this.SACHes = new HashSet<SACH>();
        }

        [Display(Name = "Mã bảng giá")]
        public int ID_BANGGIA { get; set; }

        [Display(Name = "Giá nhập")]
        public Nullable<double> GIA_NHAP { get; set; }

        [Display(Name = "Giá bán")]
        public Nullable<double> GIA_BAN { get; set; }
        [Display(Name = "Giá bìa")]
        public Nullable<double> GIA_BIA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
