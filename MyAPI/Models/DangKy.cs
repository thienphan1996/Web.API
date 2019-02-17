using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    [Table("dangky")]
    public class DangKy : EntityBase
    {
        public DangKy() { }

        [Key]
        public int stt { get; set; }
        public string mskh { get; set; }
        public string malophoc { get; set; }
        public string ngaydangky { get; set; }
        public double? muchocphi { get; set; }
        public int? miengiam { get; set; }
        public double? duatruoc { get; set; }
        public double? conlai { get; set; }
        public string ghichu { get; set; }
        public string msphieuthu { get; set; }
        public int vang_tuan1 { get; set; }
        public int vang_tuan2 { get; set; }
        public int vang_tuan3 { get; set; }
        public int vang_tuan4 { get; set; }
        public int vang_tuan5 { get; set; }
        public int vang_tuan6 { get; set; }
        public int vang_tuan7 { get; set; }
        public int vang_tuan8 { get; set; }
        public int vang_tuan9 { get; set; }
        public int vang_tuan10 { get; set; }
        public int vang_tuan11 { get; set; }
        public int vang_tuan12 { get; set; }
        public int songayvang { get; set; }
        public float diem_kn1 { get; set; }
        public float diem_kn2 { get; set; }
        public float diem_kn3 { get; set; }
        public float diem_kn4 { get; set; }
        public float diem_tong { get; set; }
    }
}