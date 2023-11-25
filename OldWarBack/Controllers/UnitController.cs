using Domain.Body;
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
        private readonly UnitRepository _repository;
        #endregion

        #region Constructor
        public UnitController(UnitRepository repository)
        {
            _repository = repository;
        }
        #endregion

        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Unit>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        [Route("Create")]
        public async Task Create([FromBody] UnitBody unit)
        {

            await _repository.AddAsync(new Unit(unit));
        }

        [HttpPut]
        [Route("Update")]
        public void Update([FromBody] Unit unit)
        {
            _repository.Update(unit);
        }

        [HttpDelete]
        [Route("Delete")]
        public void Delete([FromBody] Unit unit)
        {
            _repository.Remove(unit);
        }
    }
}
