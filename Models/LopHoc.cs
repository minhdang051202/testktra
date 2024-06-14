using System.ComponentModel.DataAnnotations;

namespace NMD_2021050190.Models
{
    public class LopHoc
    {
        [Key]
        public String MaLop { get; set; }
        public string TenLop { get; set; }
    }

}

