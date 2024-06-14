using System.ComponentModel.DataAnnotations;

namespace NMD_2021050190.Models
{
public class SinhVien

{
    [Key]
    public string MaSinhVien { get; set; }
    public string HoTen { get; set; }
    public string MaLop { get; set; }
}
}
