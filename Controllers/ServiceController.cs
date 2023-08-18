
using BeautySolun_API.Repository.Interface;
using BeautySolun_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeautySolun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<ServiceModel>>> GetAllService()
        {
            List<ServiceModel> serviceModel = await _serviceRepository.FindAll();
            return Ok(serviceModel);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceModel>> GetById(int id)
        {
            ServiceModel serviceModel = await _serviceRepository.FindById(id);
            return Ok(serviceModel);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceModel>> AddService(ServiceModel serviceModel)
        {
            ServiceModel service =  await _serviceRepository.AddService(serviceModel);
            return Ok(service);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceModel>> UpdateService(ServiceModel serviceModel,int id)
        {

            serviceModel.Id_service = id;
            ServiceModel service = await _serviceRepository.UpdateService(serviceModel,id);
            return Ok(service);
        }
    }
}
