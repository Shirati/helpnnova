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
    public class ProcedureRepository:IModels<Procedure>
    {
        IContext _context;
        public ProcedureRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Procedure> Add(Procedure entity)
        {
            EntityEntry<Procedure> newEntity = _context.Procedures.Add(entity);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            _context.Procedures.Remove(_context.Procedures.Single(a => a.ProcedureId == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Procedure>> GetAll()
        {
            return await _context.Procedures.ToListAsync();
        }

        public async Task<Procedure> GetById(int id)
        {
            return await _context.Procedures.SingleAsync(a => a.ProcedureId == id);
        }

        public async Task<Procedure> Update(Procedure entity)
        {
            Delete(entity.ProcedureId);
            return await Add(entity);
        }
    }
}

