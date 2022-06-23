using Microsoft.AspNetCore.Mvc;
using SpoonSmpCore.Models.Database;
using SpoonSmpInfrastructure.Interfaces;
using System.Threading.Tasks;

namespace SpoonSmpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemUserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SystemUserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _unitOfWork.SystemRepository.GetById(id);
            return Ok(data);
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _unitOfWork.SystemRepository.GetAll();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(SystemUser user)
        {
            var data = await _unitOfWork.SystemRepository.Add(user);
            var response = new
            {
                Status = 200,
                Response = "Action completed",
                Company = "SpoonServices",
                Data = data
            };
            return Ok(response);

        }

        [HttpPut]
        public async Task<IActionResult> Update(SystemUser user)
        {
            var data = await _unitOfWork.SystemRepository.Update(user);
            var response = new
            {
                Status = 200,
                Response = "Action completed",
                Company = "SpoonServices",
                Data = data
            };
            return Ok(response);
        }
    }
}
