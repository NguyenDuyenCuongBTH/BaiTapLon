using System.ComponentModel.DataAnnotations;

namespace BTL_Nhom03
{
    public class Nhanvien
    {
        [Key]
        [Required(ErrorMessage ="Mã nhân viên không được bỏ trống")]
        [Display( Name = "Mã NV")]
        public string MaNhanVien { get; set; }

        [Required(ErrorMessage ="Tên nhân viên không được bỏ trống")]
        [Display( Name = "Tên NV")]
        public string TenNhanVien { get; set; }

        [Required(ErrorMessage ="Địa chỉ không được bỏ trống")]
        [Display( Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display( Name = "Số điện thoại")]
        public int Sdt { get; set; }
        
    }
}