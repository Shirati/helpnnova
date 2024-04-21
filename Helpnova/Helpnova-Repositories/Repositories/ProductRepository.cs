using Helpnova_Repositories.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpnova_Repositories.Repositories
{
    public class ProductRepository :IModels<Product>
    {
         IContext _context;
    public ProductRepository(IContext context)
    {
        _context = context;
    }
    public async Task<Product> Add(Product entity)
    {
        EntityEntry<Product> newEntity = _context.Products.Add(entity);
        await _context.SaveChangesAsync();
        return newEntity.Entity;
    }

    public async Task Delete(int id)
    {
        _context.Products.Remove(_context.Products.Single(a => a.ProductId == id));
        await _context.SaveChangesAsync();
    }

    public async Task<List<Product>> GetAll()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetById(int id)
    {
        return await _context.Products.SingleAsync(a => a.ProductId == id);
    }

    public async Task<Product> Update(Product entity)
    {
        Delete(entity.ProductId);
        return await Add(entity);
    }
}
    }

