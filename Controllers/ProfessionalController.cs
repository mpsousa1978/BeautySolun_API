using BeautySolun_API.Models;
using BeautySolun_API.Repository;
using BeautySolun_API.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautySolun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionalController : ControllerBase
    {

        private readonly IProfessionalRepository _professionalRepository;

        public ProfessionalController(IProfessionalRepository professionalRepository)
        {
            _professionalRepository = professionalRepository;
        }

        [HttpGet("status/{id_status}")]
        public async Task<ActionResult<List<ProfessionalModel>>> GetAllProfessionalByStatus(int id_status)
        {
            List<ProfessionalModel> professionalModel = await _professionalRepository.FindAll(id_status);
            return professionalModel;
        }

        [HttpGet("Time/{id},{dateTime}")]
        public async Task<ActionResult<List<TimeModel>>> GetAvailableTimes(int id,string dateTime)

        {

            List<TimeModel> professionalModel = await _professionalRepository.GetAvailableTimes( id, dateTime);
            return professionalModel;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessionalModel>> GetProfessionalById(int id)
        {
            ProfessionalModel professionalModel = await _professionalRepository.FindById(id);
            return professionalModel;
        }

        [HttpPost]
        public async Task<ActionResult<ProfessionalModel>> AddProfessional(ProfessionalModel professionalModel)
        {
            ProfessionalModel professional = await _professionalRepository.AddProfessional(professionalModel);
            return Ok(professional);

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ProfessionalModel>> UpdateProfessional(ProfessionalModel professionalModel,int id)
        {
            professionalModel.Id_professional = id;
            ProfessionalModel professional = await _professionalRepository.UpdateProfessional(professionalModel,id);
            return Ok(professionalModel);
        }



    }
}
