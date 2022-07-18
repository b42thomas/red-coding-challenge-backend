using System;
using System.Collections.Generic;
using System.Linq;
using API.Interfaces;
using API.Models;
using API.Enums;

namespace API.Projections
{
    public class Order : IDataProvider
    {
        public Order(Models.Order o)
        {
            OrderId = o.OrderId;
            CreatedByUserName = o.CreatedByUserName;
            CustomerName = o.CustomerName;
            CreatedDate = o.CreatedDate.ToLongDateString();
            OrderType = o.OrderType.ToString();
            Uid = o.Uid;
        }

        public int OrderId { get; set; }
        public string OrderType { get; set; }
        public string CustomerName { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedByUserName { get; set; }
        public Guid Uid { get; set;}

        public IEnumerable<Projections.Order> GetData() {
            return Program.Data.Values.Select(o => new Projections.Order(o));
        }

        public Projections.Order FindData(Guid uid) {
            var order = Program.Data.Values.Where(order => order.Uid == uid).FirstOrDefault();
            return new Projections.Order(order);
        }

        public Projections.Order CreateOrder(string customerName, int orderType, string createdByUserName) {
            var orderId = Program.Data.Values.Count() + 1;
            var createdDate = DateTime.UtcNow;
            var uid = Guid.NewGuid();
            var order = new Models.Order {
                OrderId = orderId,
                OrderType = (OrderType)orderType,
                CustomerName = customerName,
                CreatedDate = createdDate,
                CreatedByUserName = createdByUserName,
                Uid = uid,
            };
            Program.Data.Add(orderId, order);
            return new Projections.Order(order);
        }

        public void DeleteData(Guid guid) {
            
        }
    }
}