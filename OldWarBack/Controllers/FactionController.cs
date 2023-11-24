using Domain.Concrete;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace OldWarBack.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]")]
    public class FactionController : Controller
    {
        #region field
        private readonly Repository<Faction> _repository;
        #endregion

        #region Constructor
        public FactionController(Repository<Faction> repository)
        {
            _repository = repository;
        }
        #endregion

        [HttpGet]
        public async Task<IEnumerable<Faction>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IEnumerable<Faction>> GetAll_1()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPut]
        public async Task<IEnumerable<Faction>> GetAll_2()
        {
            return await _repository.GetAllAsync();
        }

        [HttpDelete]
        public async Task<IEnumerable<Faction>> GetAll_3()
        {
            return await _repository.GetAllAsync();
        }
    }
}