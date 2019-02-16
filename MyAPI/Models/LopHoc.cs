using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    [Table("lophoc")]
    public class LopHoc : EntityBase
    {
        public LopHoc() { }

        [Key]
        public int malophoc { get; set; }
        public string tenlophoc { get; set; }
        public int? sisolop { get; set; }
        public int? soluongdangky { get; set; }
        public string trangthaidangky { get; set; }
        public int? makhoahoc { get; set; }
        public string malop { get; set; }
        public int? msgv { get; set; }
        public int? dayofweek { get; set; }
        public double? muchocphi { get; set; }
        public string manv1 { get; set; }
        public string manv2 { get; set; }
        public string manv3 { get; set; }
        public string manv4 { get; set; }
        public string ghichu { get; set; }
    }
}