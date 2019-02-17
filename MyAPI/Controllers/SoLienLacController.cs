using MyAPI.Core;
using MyAPI.Models;
using MyAPI.Service;
using MyAPI.ViewModels;
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

        [HttpGet]
        [Route("api/solienlac/my/{user}")]
        public IEnumerable<SoLienLac> GetByUser(string user)
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

        [HttpPost]
        [Route("api/solienlac/create/{user}")]
        public IHttpActionResult Create(string user, [FromBody] SoLienLacViewModel viewModel)
        {
            var res = _service.Create(user, viewModel);
            if (!res)
                throw new ApiException("Không thể thêm thông báo", (int)HttpStatusCode.Forbidden);

            return Ok();
        }
    }
}
