using System.ComponentModel.DataAnnotations;

namespace BTL_Nhom03
{
    public class Khachhang
    {
        [Key]
        [Required(ErrorMessage ="Mã Khách Hàng không được bỏ trống")]
        [Display( Name = "Mã Khách Hàng")]
        public string MaKhachHang { get; set; }

        [Required(ErrorMessage ="Tên khách hàng không được bỏ trống")]
        [Display( Name = "Tên khách hàng")]
        public string TenKhachHang { get; set; }

        [Required(ErrorMessage ="Địa chỉ không được bỏ trống")]
        [Display( Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        
        [Display( Name = "Số điện thoại")]
        public int Sdt { get; set; }
    }
}