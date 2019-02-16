using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    [Table("khoahoc")]
    public class KhoaHoc : EntityBase
    {
        public KhoaHoc() { }

        [Key]
        public int stt { get; set; }
        public int? makhoahoc { get; set; }
        public string tenkhoahoc { get; set; }
        public string ngaybatdau { get; set; }
        public string ngayketthuc { get; set; }
        public string ghichu { get; set; }
        public int? qui { get; set; }
        public int? nam { get; set; }
        public int? thang { get; set; }
    }
}