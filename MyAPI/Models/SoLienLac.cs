using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    [Table("solienlac")]
    public class SoLienLac : EntityBase
    {
        public SoLienLac() { }

        [Key]
        public int stt { get; set; }
        public string mskh { get; set; }
        public string makhoahoc { get; set; }
        public string malophoc { get; set; }
        public string ykiengiaovien { get; set; }
        public string thangnhanxet { get; set; }
        public string ykienphuhuynh { get; set; }
        public string ghichu { get; set; }
        public string duyet { get; set; }
    }
}