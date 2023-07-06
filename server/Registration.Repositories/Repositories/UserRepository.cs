using Microsoft.EntityFrameworkCore;
using Registration.Repositories.Entities;
using Registration.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Registration.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User user)
        {
            var newUser =_context.Users.Add(user);
            await _context.SaveChangesAsync();
            return newUser.Entity;
        }

        public async Task DeleteAsync(string id)
        {
            var user = await GetByIdAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();

        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _context.Users.FindAsync(id);

        }

        public async Task<User> UpdateAsync(User user)
        {
            User newUser = await GetByIdAsync(user.Id);
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.DateBorn = user.DateBorn;
            newUser.HMO = user.HMO;
            newUser.Gender = user.Gender;
            await _context.SaveChangesAsync();
            return newUser;


        }

    }
}
