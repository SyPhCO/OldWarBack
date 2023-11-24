﻿using Domain.Concrete;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace OldWarBack.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]")]
    public class AllianceCountryController : Controller
    {
        #region field
        private readonly Repository<Alliance_Country> _repository;
        #endregion

        #region Constructor
        public AllianceCountryController(Repository<Alliance_Country> repository)
        {
            _repository = repository;
        }
        #endregion

        [HttpGet]
        public async Task<IEnumerable<Alliance_Country>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IEnumerable<Alliance_Country>> GetAll_1()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPut]
        public async Task<IEnumerable<Alliance_Country>> GetAll_2()
        {
            return await _repository.GetAllAsync();
        }

        [HttpDelete]
        public async Task<IEnumerable<Alliance_Country>> GetAll_3()
        {
            return await _repository.GetAllAsync();
        }
    }
}
