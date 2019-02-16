using MyAPI.Models;
using MyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Service
{
    public class NhanVienService
    {
        NhanVienRepository _repository;

        public NhanVienService()
        {
            _repository = new NhanVienRepository();
        }

        public IEnumerable<NhanVien> GetAll()
        {
            return _repository.List().ToList();
        }
    }
}