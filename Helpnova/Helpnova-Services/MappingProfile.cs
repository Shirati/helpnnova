using AutoMapper;
using Helpnova_Gui.Models;
using Helpnova_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Helpnova_Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Procedure, ProcedureModel>().ReverseMap();
            CreateMap<ProcedureCourse, ProcedureCourseModel>().ReverseMap();
            CreateMap<Customer, CustomerModel>().ReverseMap();
            CreateMap<Course, CourseModel>().ReverseMap();
            CreateMap<Product, ProductModel>().ReverseMap();

        }
    }
}
