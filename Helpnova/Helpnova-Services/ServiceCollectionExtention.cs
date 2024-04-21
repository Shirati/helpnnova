using Helpnova_Gui.Models;
using Helpnova_Repositories;
using Helpnova_Services.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpnova_Services
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<UserModel>, UserService>();
            services.AddScoped<IService<CustomerModel>, CustomerService>();
            services.AddScoped<IService<ProductModel>, ProductService>();
            services.AddScoped<IService<CourseModel>, CourseService>();
            services.AddScoped<IService<ProcedureCourseModel>, ProcedureCourseService>();
            services.AddScoped<IService<ProcedureModel>, ProcedureService>();


           // services.AddSingleton<IContext, Context>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }


    }
}
