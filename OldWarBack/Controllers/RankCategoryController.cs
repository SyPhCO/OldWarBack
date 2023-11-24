using Domain.Concrete;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace OldWarBack.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]")]
    public class RankCategoryController : Controller
    {
        #region field
        private readonly Repository<Rank_Category> _repository;
        #endregion

        #region Constructor
        public RankCategoryController(Repository<Rank_Category> repository)
        {
            _repository = repository;
        }
        #endregion

        [HttpGet]
        public async Task<IEnumerable<Rank_Category>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<IEnumerable<Rank_Category>> GetAll_1()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPut]
        public async Task<IEnumerable<Rank_Category>> GetAll_2()
        {
            return await _repository.GetAllAsync();
        }

        [HttpDelete]
        public async Task<IEnumerable<Rank_Category>> GetAll_3()
        {
            return await _repository.GetAllAsync();
        }
    }
}
