using Helpnova_Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpnova_Repositories.Repositories
{
    public class UserRepository:IModels<User>
    {
        IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task<User> Add(User entity)
        {
            EntityEntry<User> newEntity = _context.Users.Add(entity);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            //_context.Users.Remove(_context.Users.Single(a => a.UserLogin == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return new User(); //await _context.Users.SingleAsync(a => a.ActionId == id);
        }

        public async Task<User> Update(User entity)
        {
           // Delete(entity.ActionId);
            return await Add(entity);
        }
    }
}
