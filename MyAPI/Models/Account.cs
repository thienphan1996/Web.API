using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyAPI.Models
{
    [Table("login")]
    public class Account : EntityBase
    {
        public Account() { }

        [Key]
        public string user { get; set; }
        public string pass { get; set; }
        public string per { get; set; }
    }
}