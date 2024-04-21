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
    public class ProcedureService:IService<ProcedureModel>
    {
        private readonly IMapper _mapper;
        private readonly IModels<Procedure> _procedureRepository;

        public ProcedureService(IMapper mapper, IModels<Procedure> procedureRepository)
        {
            _mapper = mapper;
            _procedureRepository = procedureRepository;
        }

        public async Task<ProcedureModel> Add(ProcedureModel entity)
        {
            return _mapper.Map<ProcedureModel>(await _procedureRepository.Add(_mapper.Map<Procedure>(entity)));
        }

        public async Task Delete(int id)
        {
            await _procedureRepository.Delete(id);
        }

        public async Task<List<ProcedureModel>> GetAll()
        {
            return _mapper.Map<List<ProcedureModel>>(await _procedureRepository.GetAll());
        }

        public async Task<ProcedureModel> GetById(int id)
        {
            return _mapper.Map<ProcedureModel>(await _procedureRepository.GetById(id));
        }

        public async Task<ProcedureModel> Update(ProcedureModel entity)
        {
            return _mapper.Map<ProcedureModel>(await _procedureRepository.Update(_mapper.Map<Procedure>(entity)));
        }
    }
}
