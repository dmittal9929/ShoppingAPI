using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectShopping.Entities;
using ProjectShopping.Models;
using ProjectShopping.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IShoppingRepository _repository;
        private readonly IMapper _mapper;
        public ProductsController(IShoppingRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpGet]
        public IEnumerable<ProductsDTO> GetProducts(string gender)
        {

            var productFromRepo = _repository.GetProducts(gender);
            return (_mapper.Map<IEnumerable<ProductsDTO>>(productFromRepo));
        }
        

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(Guid id)
        {
            return _repository.GetProduct(id);
        }


        
    }
}
