using MyAPI.Models;
using MyAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyAPI.Controllers
{
    public class NhanVienController : ApiController
    {
        NhanVienService _service;
        public NhanVienController()
        {
            _service = new NhanVienService();
        }

        // GET api/values
        public IEnumerable<NhanVien> Get()
        {
            return _service.GetAll();
        }
    }
}
