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
    public class LopHocController : ApiController
    {
        LopHocService _service;
        public LopHocController()
        {
            _service = new LopHocService();
        }

        // GET api/values
        public IEnumerable<LopHoc> Get()
        {
            return _service.GetAll();
        }
    }
}
