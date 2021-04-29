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
    [Route("api/user/{id}/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IShoppingRepository _repository;
        private readonly IMapper _mapper;
        public OrderController(IShoppingRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpPost]
        public ActionResult PlaceOrder(Guid id,[FromBody]OrderCreationDTO order)
        {
            Console.WriteLine(id);
            var EntityOrder = _mapper.Map<Order>(order);
            _repository.AddOrder(EntityOrder,id);
            _repository.save();
            return Ok();

        }

    }
}
