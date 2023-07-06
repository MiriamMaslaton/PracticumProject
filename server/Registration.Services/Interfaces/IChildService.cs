using Registration.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Interfaces
{
    public interface IChildService
    {
        Task <List<ChildDTO>> GetListAsync();

        Task<ChildDTO> GetByIdAsync(string id);

        Task<ChildDTO> AddAsync(ChildDTO child);

        Task<ChildDTO> UpdateAsync(ChildDTO child);

        Task DeleteAsync(string id);
    }
}
