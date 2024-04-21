using AutoMapper;
using Helpnova_Gui.Models;
using Helpnova_Repositories.Models;
using Helpnova_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpnova_Repositories.Repositories;

namespace Helpnova_Services.Models
{
    public class CustomerService:IService<CustomerModel>
    {
        private readonly IMapper _mapper;
        private readonly IModels<Customer> _customerRepository;

        public CustomerService(IMapper mapper, IModels<Customer> customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<CustomerModel> Add(CustomerModel entity)
        {
            return _mapper.Map<CustomerModel>(await _customerRepository.Add(_mapper.Map<Customer>(entity)));
        }

        public async Task Delete(int id)
        {
            await _customerRepository.Delete(id);
        }

        public async Task<List<CustomerModel>> GetAll()
        {
            return _mapper.Map<List<CustomerModel>>(await _customerRepository.GetAll());
        }

        public async Task<CustomerModel> GetById(int id)
        {
            return _mapper.Map<CustomerModel>(await _customerRepository.GetById(id));
        }

        public async Task<CustomerModel> Update(CustomerModel entity)

        {
            return _mapper.Map<CustomerModel>(await _customerRepository.Update(_mapper.Map<Customer>(entity)));
        }
    }
}
