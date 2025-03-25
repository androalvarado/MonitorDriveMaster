using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MonitorDriveAPI.Data;
using MonitorDriveAPI.Models.DTO;
using MonitorDriveAPI.Models.Entities;
using MonitorDriveAPI.Repositories;

namespace MonitorDriveAPI.Controllers
{
    //https://localhost:1234/api/users
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UsersController(ApplicationDbContext _context, IUserRepository userRepository, IMapper mapper)
        {
            this._context = _context;
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        // GET  All Users 
        // GET: https://localhost:portnumber/api/users
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Data from database - Entities
            var usersEntiti = await userRepository.GetAllAsync();

            // Map Entiti to DTOs and Return DTOs
            return Ok(mapper.Map<List<UserDto>>(usersEntiti));
        }

        // GET Single User by Id
        // GET: https://localhost:portnumber/api/users/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            // Get user entiti from database
            var userEntiti = await userRepository.GetByIdAsync(id);

            if (userEntiti == null)
                return NotFound();

            // Map User Entiti to UserDto and Return Dto back to client
            return Ok(mapper.Map<UserDto>(userEntiti));
        }

        // Post to create new user
        // Post: https://localhost:portnumber/api/regions
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserDto createUserDto)
        {
            //Map Dto to entiti
            var userEntiti = mapper.Map<User>(createUserDto);

            //use entiti to create user
            userEntiti = await userRepository.CreateAsync(userEntiti);

            //Map Entiti back to dto
            var userDto = mapper.Map<UserDto>(userEntiti);

            //Return
            return CreatedAtAction(nameof(GetById), new { id = userDto.Id, }, userDto);
        }

        // Update user
        // Put: https://localhost:portnumber/api/regions/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateUserDto updateUserDto)
        {
            // Map DTO to Domain Model
            var userEntiti = mapper.Map<User>(updateUserDto);

            // Check if user exits
            userEntiti = await userRepository.UpdateAsync(id, userEntiti);

            if (userEntiti == null)
                return NotFound();

            // Convert Entiti to Dto
            var userDto = mapper.Map<UserDto>(userEntiti);

            return CreatedAtAction(nameof(GetById), new { id = userDto.Id, }, userDto);
        }

        // Delete User
        // DELETE: https://localhost:portnumber/api/regions/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            // Check if user exits
            var userEntiti = await userRepository.DeleteAsync(id);

            if (userEntiti == null)
                return NotFound();

            // Map Entiti to DTO and Return delete user
            return Ok(mapper.Map<UserDto>(userEntiti));
        }
    }
}
