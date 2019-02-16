using MyAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyAPI.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class GvDbContext : DbContext
    {
        public GvDbContext() : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<DangKy> DangKy { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHoc { get; set; }
        public virtual DbSet<LopHoc> LopHoc { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<SoLienLac> SoLienLac { get; set; }
    }
}