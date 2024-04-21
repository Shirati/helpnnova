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
    public class ProcedureCourseRepository:IModels<ProcedureCourse>
    {
        IContext _context;
        public ProcedureCourseRepository(IContext context)
        {
            _context = context;
        }
        public async Task<ProcedureCourse> Add(ProcedureCourse entity)
        {
            EntityEntry<ProcedureCourse> newEntity = _context.ProcedureCourses.Add(entity);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            _context.ProcedureCourses.Remove(_context.ProcedureCourses.Single(a => a.ProcedureCourseId == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProcedureCourse>> GetAll()
        {
            return await _context.ProcedureCourses.ToListAsync();
        }

        public async Task<ProcedureCourse> GetById(int id)
        {
            return await _context.ProcedureCourses.SingleAsync(a => a.ProcedureCourseId == id);
        }

        public async Task<ProcedureCourse> Update(ProcedureCourse entity)
        {
            Delete(entity.ProcedureCourseId);
            return await Add(entity);
        }
    }
}

