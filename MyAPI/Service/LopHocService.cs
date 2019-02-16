using MyAPI.Models;
using MyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Service
{
    public class LopHocService
    {
        LopHocRepository _repository;

        public LopHocService()
        {
            _repository = new LopHocRepository();
        }

        public IEnumerable<LopHoc> GetAll()
        {
            return _repository.List().ToList();
        }
    }
}