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
    public class KhachHangController : ApiController
    {
        KhachHangService _service;
        public KhachHangController()
        {
            _service = new KhachHangService();
        }

        // GET api/values
        public IEnumerable<KhachHang> Get()
        {
            return _service.GetAll();
        }
    }
}
