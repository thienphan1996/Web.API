using MyAPI.Models;
using MyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Service
{
    public class KhoaHocService
    {
        KhoaHocRepository _repository;

        public KhoaHocService()
        {
            _repository = new KhoaHocRepository();
        }

        public IEnumerable<KhoaHoc> GetAll()
        {
            return _repository.List().ToList();
        }
    }
}