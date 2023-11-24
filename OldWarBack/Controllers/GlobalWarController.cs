using Domain.Concrete;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace OldWarBack.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]")]
    public class GlobalWarController : Controller
    {
        #region field
        private readonly Repository<GlobalWar> _repository;
        #endregion

        #region Constructor
        public GlobalWarController(Repository<GlobalWar> repository)
        {
            _repository = repository;
        }
        #endregion

        [HttpGet]
        public async Task<IEnumerable<GlobalWar>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IEnumerable<GlobalWar>> GetAll_1()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPut]
        public async Task<IEnumerable<GlobalWar>> GetAll_2()
        {
            return await _repository.GetAllAsync();
        }

        [HttpDelete]
        public async Task<IEnumerable<GlobalWar>> GetAll_3()
        {
            return await _repository.GetAllAsync();
        }
    }
}