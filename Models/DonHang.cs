//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wine_e_commerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.ItemCarts = new HashSet<ItemCart>();
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int MaDonHang { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public Nullable<int> TongSanPham { get; set; }
        public string DiaChiNhanHang { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public Nullable<int> idKhachHang { get; set; }
        public Nullable<System.DateTime> ngayDat { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCart> ItemCarts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
