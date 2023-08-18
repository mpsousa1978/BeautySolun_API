using BeautySolun_API.Integration;
using BeautySolun_API.Integration.Interface;
using BeautySolun_API.Integration.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BeautySolun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        private readonly IViaCodeIntegration _viaCodeIntegration;

        public CodeController(IViaCodeIntegration viaCodeIntegration)
        {
            _viaCodeIntegration = viaCodeIntegration;
        }

        [HttpGet("{Code}")]
        public async Task<ActionResult<ViaCodeResponse>> GetDataCode(string Code)
        {
          var responseData =   await _viaCodeIntegration.GetDataCode(Code);

            if (responseData == null)
            {
                return BadRequest("Code not found");
            }
            return Ok(responseData);    
        }
    }
}
