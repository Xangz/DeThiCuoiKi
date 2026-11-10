using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NguyenDinhSang_241230832.Models;

public partial class HangHoa
{
    [Key]
    public int MaHang { get; set; }
    [Required(ErrorMessage = "Mã loại không được để trống")]
    public int MaLoai { get; set; }
    [Required(ErrorMessage = "Tên hàng không được để trống")]
    public string TenHang { get; set; } = null!;
    [Required(ErrorMessage = "Giá không được để trống")]
    [Range(100, 5000, ErrorMessage = "Giá phải là số và nằm trong khoảng từ 100 đến 5000")]
    public decimal? Gia { get; set; }
    [RegularExpression(@"^.+\.(jpg|png|gif|tiff)$", ErrorMessage = "Tên file ảnh phải có đuôi: .jpg | .png | .gif | .tiff")]
    public string? Anh { get; set; }

    public virtual LoaiHang MaLoaiNavigation { get; set; } = null!;
}
