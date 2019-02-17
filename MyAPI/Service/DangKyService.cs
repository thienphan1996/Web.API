using MyAPI.Core;
using MyAPI.Models;
using MyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Service
{
    public class DangKyService
    {
        DangKyRepository _repository;
        KhachHangRepository _khachHangRepository;
        public DangKyService()
        {
            _repository = new DangKyRepository();
            _khachHangRepository = new KhachHangRepository();
        }

        public IEnumerable<DangKy> GetAll()
        {
            return _repository.List().ToList();
        }

        public IEnumerable<DangKy> Get(string user)
        {
            var khachhang = _khachHangRepository.GetByUser(user);
            if (khachhang == null)
            {
                throw new ApiException("Mã số khách hàng không chính xác.");
            }

            var results = GetAll().Where(d => (d.mskh + string.Empty) == khachhang.mskh).ToList();
            return results;
        }
    }
}