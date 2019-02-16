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
        public DangKyService()
        {
            _repository = new DangKyRepository();
        }

        public IEnumerable<DangKy> GetAll()
        {
            return _repository.List();
        }
    }
}