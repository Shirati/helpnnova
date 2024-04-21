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
    public class ProcedureCourseService:IService<ProcedureCourseModel>
    {
        private readonly IMapper _mapper;
        private readonly IModels<ProcedureCourse> _procedureCourseRepository;

        public ProcedureCourseService(IMapper mapper, IModels<ProcedureCourse> procedureCourseRepository)
        {
            _mapper = mapper;
            _procedureCourseRepository = procedureCourseRepository;
        }

        public async Task<ProcedureCourseModel> Add(ProcedureCourseModel entity)
        {
            return _mapper.Map<ProcedureCourseModel>(await _procedureCourseRepository.Add(_mapper.Map<ProcedureCourse>(entity)));
        }

        public async Task Delete(int id)
        {
            await _procedureCourseRepository.Delete(id);
        }

        public async Task<List<ProcedureCourseModel>> GetAll()
        {
            return _mapper.Map<List<ProcedureCourseModel>>(await _procedureCourseRepository.GetAll());
        }

        public async Task<ProcedureCourseModel> GetById(int id)
        {
            return _mapper.Map<ProcedureCourseModel>(await _procedureCourseRepository.GetById(id));
        }

        public async Task<ProcedureCourseModel> Update(ProcedureCourseModel entity)
        {
            return _mapper.Map<ProcedureCourseModel>(await _procedureCourseRepository.Update(_mapper.Map<ProcedureCourse>(entity)));
        }
    }
}
