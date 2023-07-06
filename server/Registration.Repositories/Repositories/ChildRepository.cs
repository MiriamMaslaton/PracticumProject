using Microsoft.EntityFrameworkCore;
using Registration.Repositories.Entities;
using Registration.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child child)
        {
            var newChild = _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return newChild.Entity;
        }

        public async Task DeleteAsync(string id)
        {
            var child = await GetByIdAsync(id);
            _context.Children.Remove(child);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();

        }

        public async Task<Child> GetByIdAsync(string id)
        {
            return await _context.Children.FindAsync(id);

        }

        public async Task<Child> UpdateAsync(Child child)
        {
            Child newChild = await GetByIdAsync(child.Id);
            newChild.Name = child.Name;
            newChild.DateBorn = child.DateBorn;
            await _context.SaveChangesAsync();
            return newChild;


        }
    }
}
