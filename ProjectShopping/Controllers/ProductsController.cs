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
        public IEnumerable<ProductsDTO> GetProducts()
        {

            var productfFromRepo  = _repository.GetProducts();
            return (_mapper.Map<IEnumerable<ProductsDTO>>(productfFromRepo));
        }

        [HttpPost]
        public ActionResult PostProducts(ProductCreatingDTO p)
        {
            var productEntity = _mapper.Map<Product>(p);
            _repository.AddProduct(productEntity);
            _repository.save();
            return Ok();
        }
    }
}
