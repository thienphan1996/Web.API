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
    public class SoLienLacController : ApiController
    {
        SoLienLacService _service;
        public SoLienLacController()
        {
            _service = new SoLienLacService();
        }

        // GET api/values
        public IEnumerable<SoLienLac> Get()
        {
            return _service.GetAll();
        }
    }
}
