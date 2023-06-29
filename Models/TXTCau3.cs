using System.ComponentModel.DataAnnotations;

namespace BaiThiTXT.Models
{
    public class TXTCau3
    {
        [Key]
        [Display(Name ="Mã Lớp")]
        public int? MaLop {get;set;}
        [Display(Name ="Tên Lớp")]
        public string? TenLop {get;set;}
        [Display(Name ="Khóa Học")]
        public int? KhoaHoc {get;set;}
    }
}