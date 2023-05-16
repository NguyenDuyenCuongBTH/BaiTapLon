using System.ComponentModel.DataAnnotations;

namespace BTL_Nhom03
{
    public class Nhacungcap
    {
        [Key]
        [Required(ErrorMessage ="Mã nhà cung cấp không được bỏ trống")]
        [Display( Name = "Mã nhà cung cấp")]
        public string? MaNCC { get; set; }

        [Required(ErrorMessage ="Tên nhà cung cấp không được bỏ trống")]
        [Display(Name = "Tên Nhà cung cấp")]
        public string? TenNCC { get; set; }

        [Display(Name = "Số điện thoại")]
        public string? Sdt { get; set; }

        [Required(ErrorMessage ="Địa chỉ không được bỏ trống")]
        [Display(Name = "Địa chỉ")]
        public string? DiaChi { get; set; }

        [Required(ErrorMessage ="Email không được bỏ trống")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email.?")]
         public string? Email { get; set; }
    }
}