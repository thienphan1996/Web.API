using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    [Table("dsbacsi")]
    public class NhanVien : EntityBase
    {
        public NhanVien() { }

        [Key]
        public int msbs { get; set; }
        public string user { get; set; }
        public string hotenbs { get; set; }
        public string namsinh { get; set; }
        public string gioitinh { get; set; }
        public string nghenghiep { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public string email { get; set; }
        public string ghichu { get; set; }
    }
}