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
    public class CustomerRepository : IModels<Customer>
    {
        IContext _context;
        public CustomerRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Customer> Add(Customer entity)
        {
            EntityEntry<Customer> newEntity = _context.Customers.Add(entity);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            _context.Customers.Remove(_context.Customers.Single(a => a.CustomerId == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _context.Customers.SingleAsync(a => a.CustomerId == id);
        }

        public async Task<Customer> Update(Customer entity)
        {
             Delete(entity.CustomerId);
            return await Add(entity);
        }
    }
}
