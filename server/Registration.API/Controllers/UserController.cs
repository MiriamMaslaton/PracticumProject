using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Registration.Common.DTOs;
using Registration.Services.Interfaces;
using Registration.Services.Services;

namespace Registration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetListAsync();
        }
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(string id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
             await _userService.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<UserDTO> Update([FromBody] UserDTO model)
        {
            return await _userService.UpdateAsync(new UserDTO()
            { Id = model.Id, FirstName = model.FirstName, LastName = model.LastName, HMO = model.HMO, Gender = model.Gender, DateBorn = model.DateBorn });
        }
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserDTO model)
        {
            UserDTO user = await _userService.AddAsync(new UserDTO()
            { FirstName = model.FirstName, LastName = model.LastName, HMO = model.HMO, Gender = model.Gender, DateBorn = model.DateBorn });
            return user;
        }


    }

}
