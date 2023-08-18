
using BeautySolun_API.Models;
using BeautySolun_API.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BeautySolun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly ITimeRepository _timeRepository;

        public TimeController(ITimeRepository timeRepository)
        {
            _timeRepository = timeRepository;
        }

        [HttpGet] 
        public async Task<ActionResult<List<TimeModel>>> GetAllTime() 
        {
            List<TimeModel> timeLista = await _timeRepository.FindAll();
            return Ok(timeLista);
        }
    }
}
