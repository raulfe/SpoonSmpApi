using Microsoft.AspNetCore.Mvc;
using SpoonSmpCore.Models.Database;
using SpoonSmpInfrastructure.Interfaces;
using System.Threading.Tasks;

namespace SpoonSmpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistedUserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegistedUserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _unitOfWork.RegistedRepository.GetById(id);
            return Ok(data);
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _unitOfWork.RegistedRepository.GetAll();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(RegistedUser user)
        {
            var data = await _unitOfWork.RegistedRepository.Add(user);
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
        public async Task<IActionResult> Update(RegistedUser user)
        {
            var data = await _unitOfWork.RegistedRepository.Update(user);
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
