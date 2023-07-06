using Registration.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Repositories.Interface
{
    public interface IChildRepository
    {
        Task <List<Child>>  GetAllAsync();

        Task<Child> GetByIdAsync(string id);

        Task<Child> AddAsync(Child child);

        Task<Child> UpdateAsync(Child child);

        Task DeleteAsync(string id);
    }
}
