using MyAPI.Models;
using MyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Service
{
    public class SoLienLacService
    {
        SoLienLacRepository _repository;

        public SoLienLacService()
        {
            _repository = new SoLienLacRepository();
        }

        public IEnumerable<SoLienLac> GetAll()
        {
            return _repository.List().ToList();
        }
    }
}