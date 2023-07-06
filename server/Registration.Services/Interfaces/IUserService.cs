using Registration.Common.DTOs;
using Registration.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetListAsync();

        Task<UserDTO> GetByIdAsync(string id);

        Task<UserDTO> AddAsync(UserDTO user);

        Task<UserDTO> UpdateAsync(UserDTO user);

        Task DeleteAsync(string id);
    }
}
