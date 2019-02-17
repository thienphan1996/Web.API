using MyAPI.Core;
using MyAPI.Models;
using MyAPI.Repositories;
using MyAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Service
{
    public class SoLienLacService
    {
        SoLienLacRepository _repository;
        KhachHangRepository _khachHangRepository;

        public SoLienLacService()
        {
            _repository = new SoLienLacRepository();
            _khachHangRepository = new KhachHangRepository();
        }

        public IEnumerable<SoLienLac> GetAll()
        {
            return _repository.List().ToList();
        }

        public IEnumerable<SoLienLac> Get(string user)
        {
            var khachhang = _khachHangRepository.GetByUser(user);
            if (khachhang == null)
            {
                throw new Exception("Mã số khách hàng không chính xác.");
            }

            var results = _repository.List().Where(r => (r.mskh + string.Empty) == user).OrderByDescending(o => o.thangnhanxet).ToList();
            return results;
        }

        public bool Create(string user, SoLienLacViewModel viewModel)
        {
            try
            {
                var khachhang = _khachHangRepository.GetByUser(user);
                if (khachhang == null)
                {
                    return false;
                }

                var solienlac = new SoLienLac();
                solienlac.mskh = viewModel.mskh;
                solienlac.makhoahoc = viewModel.makhoahoc;
                solienlac.malophoc = viewModel.malophoc;
                solienlac.ykiengiaovien = viewModel.ykiengiaovien;
                solienlac.thangnhanxet = viewModel.thangnhanxet;

                _repository.Create(solienlac);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}