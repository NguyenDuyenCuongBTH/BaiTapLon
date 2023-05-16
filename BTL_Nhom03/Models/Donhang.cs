using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL_Nhom03
{
    public class Donhang
    {
        [Key]
        [Required(ErrorMessage ="Mã đơn hàng không được bỏ trống")]
        [Display( Name = "Mã đơn hàng")]
        public string MaDonHang { get; set; }

        [Required(ErrorMessage ="Mã khách hàng không được bỏ trống")]
        [Display( Name = "Tên khách hàng")]
        public string MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        public Khachhang? Khachhang { get; set; }

        [Required(ErrorMessage ="Tên sản phẩm không được bỏ trống")]
        [Display( Name = "Tên sản phẩm")]
        public string MaSP { get; set; }
        [ForeignKey("MaSP")]
        public Sanpham? Sanpham { get; set; }

        [Required(ErrorMessage ="Giá tiền không được bỏ trống")]
        [Display( Name = "Giá tiền")]
        public decimal GiaTien { get; set; }

        [Required(ErrorMessage ="Thời gian không được bỏ trống")]
        [Display( Name = "Ngày bán")]
        [DataType(DataType.Date)]
        public DateTime NgayBan { get; set; }
    }
}