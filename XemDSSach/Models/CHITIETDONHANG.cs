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

    public partial class CHITIETDONHANG
    {
        [Display(Name = "Mã")]
        public int ID_CTDH { get; set; }

        [Display(Name = "Mã đơn hàng")]
        public Nullable<int> ID_DONHANG { get; set; }

        [Display(Name = "Mã sản phẩm")]
        public Nullable<int> ID_SACH { get; set; }

        [Display(Name = "Mã bảng giá")]
        public Nullable<int> ID_BANGGIA { get; set; }
        [Display(Name = "Mã sản phẩm")]
        public Nullable<int> ID_SPKM { get; set; }
        [Display(Name = "Số lượng")]
        public Nullable<short> SOLUONG { get; set; }
    
        public virtual BANGGIA BANGGIA { get; set; }
        public virtual DONHANG DONHANG { get; set; }
        public virtual SACH SACH { get; set; }
        public virtual SANPHAMKHUYENMAI SANPHAMKHUYENMAI { get; set; }
    }
}
