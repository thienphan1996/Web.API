using MyAPI.Data;
using MyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyAPI.Controllers
{
    public class DangKyController : ApiController
    {
        GvDbContext _context;

        public DangKyController()
        {
            _context = new GvDbContext();
        }

        // GET api/values
        public List<DangKy> Get()
        {
            return _context.DangKy.ToList();
        }

    }
}
