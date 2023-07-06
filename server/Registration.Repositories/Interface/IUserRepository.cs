using Registration.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Repositories.Interface
{
    public interface IUserRepository
    {

        Task<List<User>> GetAllAsync();

        Task<User> GetByIdAsync(string id);

        Task<User> AddAsync(User user);

        Task<User> UpdateAsync(User user);

        Task DeleteAsync(string id);
    }
}
