using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MonitorDriveAPI.Models.DTO;
using MonitorDriveAPI.Models.Entities;
using MonitorDriveAPI.Repositories;

namespace MonitorDriveAPI.Controllers
{
    // /api/vehicles
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private IMapper mapper;
        private IVehicleRepository repository;

        public VehiclesController(IMapper mapper, IVehicleRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        // Create Vehicle
        // POST: /api/vehicle
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateVehicleDto createDto)
        {
            // Map DTO to Entiti
            var model = mapper.Map<Vehicle>(createDto);

            await repository.CreateAsync(model);

            // Map Entiti to DTO
            return Ok(mapper.Map<VehicleDto>(model));

        }

        // Get Vehicles 
        // GET: /api/vehicles
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var model = await repository.GetAllAsync();

            return Ok(mapper.Map<List<VehicleDto>>(model));
        }

        // Get Vehicle by ID
        // GET: /api/vehicle
        //public GetById
    }
}
