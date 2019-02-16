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
    public class AccountController : ApiController
    {
        AccountService _service;
        public AccountController()
        {
            _service = new AccountService();
        }

        // GET api/values
        public IEnumerable<Account> Get()
        {
            return _service.GetAll();
        }
    }
}
