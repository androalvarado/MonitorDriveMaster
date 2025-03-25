using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitorDriveAPI.Models.DTO;
using MonitorDriveAPI.Models.Entities;
using MonitorDriveAPI.Repositories;

namespace MonitorDriveAPI.Controllers
{
    // /api/[controller]
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IDriverRepository driverRepository;

        public DriversController(IMapper mapper, IDriverRepository driverRepository)
        {
            this.mapper = mapper;
            this.driverRepository = driverRepository;
        }

        // Create Driver
        // Post: /api/driver
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDriverDto createDriverDto)
        {
            // Map DTO to Entiti
            var driverEntiti = mapper.Map<Driver>(createDriverDto);

            await driverRepository.CreateAsync(driverEntiti);

            // Map Entiti to DTO
            return Ok(mapper.Map<DriverDto>(driverEntiti));
        }

        // Get Drivers
        // GET: /api/drivers
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Data from database - Entiti
            var driverEntiti = await driverRepository.GetAllAsync();

            // Map Entiti to DTO and return
            return Ok(mapper.Map<List<DriverDto>>(driverEntiti));
        }

        // Get Driver By Id
        // Get: /api/driver/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var driverEntiti = await driverRepository.GetByIDAsync(id);

            if (driverEntiti == null)
                return NotFound();

            //Map Entiti to DTO and return
            return Ok(mapper.Map<DriverDto>(driverEntiti));
        }

        // Update Driver By Id
        // PUT: /api/driver/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdateDriverDto updateDriverDto)
        {
            // Map Dto to Entiti
            var driverEntiti = mapper.Map<Driver>(updateDriverDto);

            driverEntiti = await driverRepository.UpdateAsync(id, driverEntiti); 

            if (driverEntiti == null)
                return NotFound();


            // Map Entiti to DTO and return
            return Ok(mapper.Map<DriverDto>(driverEntiti));
        }

        // Delete a Driver by id
        // DELETE: /api/driver/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var driverEntity = await driverRepository.DeleteAsync(id);

            if (driverEntity == null)
            {
                return NotFound();
            }

            // Map Entity to DTO
            return Ok(mapper.Map<DriverDto>(driverEntity));
        }
    }
}
