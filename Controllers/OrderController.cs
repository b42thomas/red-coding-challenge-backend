
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API.Interfaces;
using API.Models;
using API.Enums;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        private readonly IDataProvider _dataProvider;
        
        public OrderController(IDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }
        [HttpGet]
        public IEnumerable<Projections.Order> Get()
        {
            // rewrite to use IDataProvider using dependency injection
            //var data = Program.Data.Values.Select(o => new Projections.Order(o));
            return _dataProvider.GetData();
        }

        // Add a Search endpoint
        [HttpGet]
        public IEnumerable<Projections.Order> Search(string customerName, int orderType)
        {
            if(!Enum.IsDefined(typeof(OrderType), orderType)){
                //return BadRequest();
            }
                
            return _dataProvider.GetData().Where(order => order.CustomerName == customerName && order.OrderType == ((OrderType)orderType).ToString());
        }

        // Add a Create endpoint
        [HttpPost]
        public Projections.Order Create(string customerName, int orderType, string createdByUserName)
        {
            if(!Enum.IsDefined(typeof(OrderType), orderType)){
                //return BadRequest();
            }
                
            return _dataProvider.CreateOrder(customerName, orderType, createdByUserName);
        }
        // Add a Delete endpoint
    }
}