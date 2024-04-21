using AutoMapper;
using Helpnova_Gui.Models;
using Helpnova_Repositories.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpnova_Repositories;

namespace Helpnova_Services.Models
{
    public  class UserService:IService<UserModel>
    {
        private readonly IMapper _mapper;
        private readonly IModels<User> _userRepository;

        public UserService(IMapper mapper, IModels<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserModel> Add(UserModel entity)
        {
            return _mapper.Map<UserModel>(await _userRepository.Add(_mapper.Map<User>(entity)));
        }

        public async Task Delete(int id)
        {
            await _userRepository.Delete(id);
        }

        public async Task<List<UserModel>> GetAll()
        {
            return _mapper.Map<List<UserModel>>(await _userRepository.GetAll());
        }

        public async Task<UserModel> GetById(int id)
        {
            return _mapper.Map<UserModel>(await _userRepository.GetById(id));
        }

        public async Task<UserModel> Update(UserModel entity)
        {
            return _mapper.Map<UserModel>(await _userRepository.Update(_mapper.Map<User>(entity)));
        }
    }
}

