using Helpnova_Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Helpnova_Repositories
{
    public interface IContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<ProcedureCourse> ProcedureCourses { get; set; }
        public DbSet<Product> Products { get; set; }

      
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}
