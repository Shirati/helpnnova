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
    public class ProductService: IService<ProductModel>
    {
        private readonly IMapper _mapper;
        private readonly IModels<Product> _productRepository;

        public ProductService(IMapper mapper, IModels<Product> productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<ProductModel> Add(ProductModel entity)
        {
            return _mapper.Map<ProductModel>(await _productRepository.Add(_mapper.Map<Product>(entity)));
        }

        public async Task Delete(int id)
        {
            await _productRepository.Delete(id);
        }

        public async Task<List<ProductModel>> GetAll()
        {
            return _mapper.Map<List<ProductModel>>(await _productRepository.GetAll());
        }

        public async Task<ProductModel> GetById(int id)
        {
            return _mapper.Map<ProductModel>(await _productRepository.GetById(id));
        }

        public async Task<ProductModel> Update(ProductModel entity)
        {
            return _mapper.Map<ProductModel>(await _productRepository.Update(_mapper.Map<Product>(entity)));
        }
    }
}
