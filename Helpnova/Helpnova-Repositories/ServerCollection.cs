using Helpnova_Repositories.Models;
using Helpnova_Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Helpnova_Repositories
{
    public static class ServerCollection
    {
        public static void AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IModels<Product>, ProductRepository>();
            service.AddScoped<IModels<User>, UserRepository>();
            service.AddScoped<IModels<Customer>, CustomerRepository>();
            service.AddScoped<IModels<Course>, CourseRepository>();
            service.AddScoped<IModels<Procedure>, ProcedureRepository>();
            service.AddScoped<IModels<ProcedureCourse>, ProcedureCourseRepository>();



        }
        public static string ToString<T>(this T obj)
        {
            string str = "";
            foreach (var item in obj.GetType().GetProperties())
            {

                if (item.PropertyType.IsArray)
                {
                    str += item.Name + ":";
                    var q = item.GetValue(obj);
                    string s = String.Join(',', q as string[]);
                    str += "\n" + s;
                }
                else str += item.Name + ":" + item?.GetValue(obj) + ",";
            }
            return str.Remove(str.Length - 1);
        }
    }
}

