using Domain.Concrete;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace OldWarBack.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]")]
    public class UnitController : Controller
    {
        #region field
        private readonly Repository<Unit> _repository;
        #endregion

        #region Constructor
        public UnitController(Repository<Unit> repository)
        {
            _repository = repository;
        }
        #endregion

        [HttpGet]
        public async Task<IEnumerable<Unit>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IEnumerable<Unit>> GetAll_1()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPut]
        public async Task<IEnumerable<Unit>> GetAll_2()
        {
            return await _repository.GetAllAsync();
        }

        [HttpDelete]
        public async Task<IEnumerable<Unit>> GetAll_3()
        {
            return await _repository.GetAllAsync();
        }
    }
}
