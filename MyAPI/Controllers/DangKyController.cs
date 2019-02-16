﻿using MyAPI.Data;
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

    }
}
