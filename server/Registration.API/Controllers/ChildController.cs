using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Registration.Common.DTOs;
using Registration.Services.Interfaces;
using Registration.Services.Services;

namespace Registration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;

        public ChildController(IChildService childService)
        {
            _childService = childService;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(string id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childService.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<ChildDTO> Update([FromBody] ChildDTO model)
        {
            return await _childService.UpdateAsync(new ChildDTO()
            { UserId = model.UserId, Name=model.Name, Id=model.Id, DateBorn=model.DateBorn});
        }
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildDTO model)
        {
            ChildDTO child = await _childService.AddAsync(new ChildDTO()
            { UserId = model.UserId, Name = model.Name, Id = model.Id, DateBorn = model.DateBorn });
            return child;
        }
      

    }
}
