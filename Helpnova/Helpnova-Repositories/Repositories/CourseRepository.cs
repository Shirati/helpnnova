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
    public class CourseRepository: IModels<Course>
    {
        IContext _context;
        public CourseRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Course> Add(Course entity)
        {
            EntityEntry<Course> newEntity = _context.Courses.Add(entity);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            _context.Courses.Remove(_context.Courses.Single(a => a.CourseId == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Course>> GetAll()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetById(int id)
        {
            return await _context.Courses.SingleAsync(a => a.CourseId == id);
        }

        public async Task<Course> Update(Course entity)
        {
            Delete(entity.CourseId);
            return await Add(entity);
        }
    }
}

