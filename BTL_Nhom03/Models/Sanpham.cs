using System.ComponentModel.DataAnnotations;

namespace BTL_Nhom03
{
    public class Sanpham
    {
        [Key]
        [Required(ErrorMessage = "Mã  sản phẩm không được để trống")]
        [Display( Name = "Mã sản phẩm")]
        public string? MaSP { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [Display( Name = "Tên sản phẩm")]
        public string? TenSP { get; set; }

        [Required(ErrorMessage = "Size không được để trống")]
        [Display( Name = "Size")]
        public int Size { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống")]
        [Display( Name = "Số lượng")]
        public decimal SoLuong { get; set; }

        [Required(ErrorMessage = "Màu sắc không được để trống")]
        [Display( Name = "Màu sắc")]
        public string? MauSac { get; set; }

        [Required(ErrorMessage = "Giá tiền không được để trống")]
        [Display( Name = "Giá tiền")]
        public decimal GiaTien { get; set; }
    }
}