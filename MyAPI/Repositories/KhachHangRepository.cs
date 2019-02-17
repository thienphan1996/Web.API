using MyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Repositories
{
    public class KhachHangRepository : Repository<KhachHang>
    {
        public KhachHangRepository() : base()
        {

        }

        public KhachHang GetByUser(string user)
        {
            var khachhang = _dbContext.KhachHang.FirstOrDefault(k => (k.mskh + string.Empty) == user);

            return khachhang;
        }
    }
}