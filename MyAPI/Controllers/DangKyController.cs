using MyAPI.Core;
using MyAPI.Data;
using MyAPI.Models;
using MyAPI.Repositories;
using MyAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyAPI.Controllers
{
    [Route("api/dangky")]
    public class DangKyController : ApiController
    {
        DangKyService _service;
        public DangKyController()
        {
            _service = new DangKyService();
        }

        // GET api/values
        public IEnumerable<DangKy> Get()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("api/dangky/my/{user}")]
        public IEnumerable<DangKy> GetByUser(string user)
        {
            try
            {
                var results = _service.Get(user);
                return results;
            }
            catch(Exception e)
            {
                throw new ApiException(e.Message, (int) HttpStatusCode.Forbidden);
            }
        }
    }
}
