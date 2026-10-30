using PraktikumWinforms.Models;
using PraktikumWinforms.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PraktikumWinforms.Controllers
{
    public class UserController
    {
        private readonly UserRepository _repository;

        public UserController(UserRepository repository)
        {
            _repository = repository;
        }

        //public List<User> GetUser()
        //{

        //}
    }
}
