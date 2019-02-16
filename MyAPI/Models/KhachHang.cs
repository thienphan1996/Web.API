using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    [Table("khachhang")]
    public class KhachHang : EntityBase
    {
        public KhachHang() { }

        [Key]
        public string mskh { get; set; }
        public string hotenkh { get; set; }
        public int? tuoi { get; set; }
        public string gioitinh { get; set; }
        public string nghenghiep { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public string email { get; set; }
        public string ghichu { get; set; }
        public string chahv { get; set; }
        public string nghenghiepcha { get; set; }
        public string dienthoaicha { get; set; }
        public string emailcha { get; set; }
        public string mehv { get; set; }
        public string nghenghiepme { get; set; }
        public string dienthoaime { get; set; }
        public string emailme { get; set; }
        public string ghichuchame { get; set; }
        public string tenkh { get; set; }
        public string matkhau { get; set; }
    }
}