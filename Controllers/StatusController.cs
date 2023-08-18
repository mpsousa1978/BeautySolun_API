using BeautySolun_API.Models;
using BeautySolun_API.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautySolun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusRepository _statusRepository;

        public StatusController(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<StatusModel>>> GetAllStatus()
        {
            List<StatusModel> statusModel = await _statusRepository.FindAll();
            return Ok(statusModel);
        }
    }
}
