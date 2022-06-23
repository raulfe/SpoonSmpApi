using Microsoft.AspNetCore.Mvc;
using SpoonSmpCore.Models.Database;
using SpoonSmpInfrastructure.Interfaces;
using System.Threading.Tasks;

namespace SpoonSmpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpaceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SpaceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _unitOfWork.SpaceRepository.GetById(id);
            return Ok(data);
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _unitOfWork.SpaceRepository.GetAll();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Spaces space)
        {
            var data = await _unitOfWork.SpaceRepository.Add(space);
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
        public async Task<IActionResult> Update(Spaces space)
        {
            var data = await _unitOfWork.SpaceRepository.Update(space);
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
