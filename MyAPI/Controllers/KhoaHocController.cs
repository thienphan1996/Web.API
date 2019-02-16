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
    public class KhoaHocController : ApiController
    {
        KhoaHocService _service;
        public KhoaHocController()
        {
            _service = new KhoaHocService();
        }

        // GET api/values
        public IEnumerable<KhoaHoc> Get()
        {
            return _service.GetAll();
        }
    }
}
