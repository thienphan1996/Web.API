using MyAPI.Models;
using MyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Service
{
    public class KhachHangService
    {
        KhachHangRepository _repository;

        public KhachHangService()
        {
            _repository = new KhachHangRepository();
        }

        public IEnumerable<KhachHang> GetAll()
        {
            return _repository.List().ToList();
        }
    }
}