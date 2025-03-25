using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MonitorDriveAPI.Models.DTO;
using MonitorDriveAPI.Models.Entities;
using MonitorDriveAPI.Repositories;

namespace MonitorDriveAPI.Controllers
{
    // /api/phones
    [Route("api/[controller]")]
    [ApiController]
    public class phonesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IPhoneRepository phoneRepository;

        public phonesController(IMapper mapper, IPhoneRepository phoneRepository)
        {
            this.mapper = mapper;
            this.phoneRepository = phoneRepository;
        }

        // Create phone 
        // POST: /api/phones
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePhoneDto createphoneDto)
        {
            // Map DTO to Entiti
            var phoneEntiti = mapper.Map<Phone>(createphoneDto);

            await phoneRepository.CreateAsync(phoneEntiti);

            // Map Entiti to Dto
            return Ok(mapper.Map<PhoneDto>(phoneEntiti));
        }

        // Get phones
        // GET: /api/phones
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var phoheEntiti = await phoneRepository.GetAllAsync();

            // Map Entiti to DTO
            return Ok(mapper.Map<List<PhoneDto>>(phoheEntiti));
        }

        // Get Phone by ID
        // GET: /api/Phones/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetByID([FromRoute] Guid id)
        {
            var phoneEntiti = await phoneRepository.GetByIdAsync(id);
            if (phoneEntiti == null)
                return NotFound();

            // Map Entiti to DTO
            return Ok(mapper.Map<PhoneDto>(phoneEntiti));
        }

        // Update Phone By Id
        // PUT: /api/Phones/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdatePhoneDto updatePhoneDto)
        {
            // Map Dto to Entiti
            var phoneEntiti = mapper.Map<Phone>(updatePhoneDto);

            phoneEntiti = await phoneRepository.UpdateAsync(id, phoneEntiti);

            if (phoneEntiti == null)
                return NotFound();

            // Map Entiti to DTO
            return Ok(mapper.Map<PhoneDto>(phoneEntiti));
        }

        // Delete phone
        // DELETE: /api/phones/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deletePhone = await phoneRepository.DeleteAsync(id);

            if (deletePhone == null)
                return NotFound();

            // Map Entiti to DTO
            return Ok(mapper.Map<PhoneDto>(deletePhone));
        }
    }
}
