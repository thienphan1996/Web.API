using MyAPI.Models;
using MyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Service
{
    public class AccountService
    {
        AccountRepository _repository;

        public AccountService()
        {
            _repository = new AccountRepository();
        }

        public IEnumerable<Account> GetAll()
        {
            return _repository.List().ToList();
        }
    }
}