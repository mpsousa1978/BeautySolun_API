using BeautySolun_API.Models;
using BeautySolun_API.Repository;
using BeautySolun_API.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautySolun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleController(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        [HttpGet("bydate/{dateTime}")]
        public async Task<ActionResult<List<ScheduleModel>>> GetAllSchedule(string dateTime)
        {
            List<ScheduleModel> scheduleModel = await _scheduleRepository.FindAll(dateTime);
            return scheduleModel;
        }

        [HttpGet("byId/{id}")]
        public async Task<ActionResult<ScheduleModel>> GetAllScheduleById(int id)
        {
            ScheduleModel scheduleModel = await _scheduleRepository.FindById(id);
            return scheduleModel;
        }

        [HttpPost]
        public async Task<ActionResult<ScheduleModel>> AddSchedule(ScheduleModel scheduleModel)
        {
            ScheduleModel Schedule = await _scheduleRepository.AddSchedue(scheduleModel);
            return Ok(Schedule);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProfessionalModel>> UpdateSchedule(ScheduleModel scheduleModel, int id)
        {
            scheduleModel.Id_schedule = id;
            ScheduleModel Schedule = await _scheduleRepository.UpdateSchedue(scheduleModel, id);
            return Ok(Schedule);
        }

    }
}
