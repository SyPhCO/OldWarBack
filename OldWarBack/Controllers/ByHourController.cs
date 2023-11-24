using Domain.Concrete;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace OldWarBack.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]")]
    public class ByHourController : Controller
    {
        #region field
        private readonly Repository<ByHour> _repository;
        #endregion

        #region Constructor
        public ByHourController(Repository<ByHour> repository)
        {
            _repository = repository;
        }
        #endregion

        [HttpGet]
        public async Task<IEnumerable<ByHour>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IEnumerable<ByHour>> GetAll_1()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPut]
        public async Task<IEnumerable<ByHour>> GetAll_2()
        {
            return await _repository.GetAllAsync();
        }

        [HttpDelete]
        public async Task<IEnumerable<ByHour>> GetAll_3()
        {
            return await _repository.GetAllAsync();
        }
    }
}
