using AutoMapper;
using Helpnova_Gui.Models;
using Helpnova_Repositories.Models;
using Helpnova_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpnova_Services.Models
{
    public class CourseService:IService<CourseModel>
    {
        private readonly IMapper _mapper;
        private readonly IModels<Course> _courseRepository;

        public CourseService(IMapper mapper, IModels<Course> courseRepository)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
        }

        public async Task<CourseModel> Add(CourseModel entity)
        {
            return _mapper.Map<CourseModel>(await _courseRepository.Add(_mapper.Map<Course>(entity)));
        }

        public async Task Delete(int id)
        {
            await _courseRepository.Delete(id);
        }

        public async Task<List<CourseModel>> GetAll()
        {
            return _mapper.Map<List<CourseModel>>(await _courseRepository.GetAll());
        }

        public async Task<CourseModel> GetById(int id)
        {
            return _mapper.Map<CourseModel>(await _courseRepository.GetById(id));
        }

        public async Task<CourseModel> Update(CourseModel entity)
        {
            return _mapper.Map<CourseModel>(await _courseRepository.Update(_mapper.Map<Course>(entity)));
        }
    }
}
