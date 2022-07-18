using System;
using System.Collections.Generic;
using API.Enums;
using API.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Program
    {
        public static Dictionary<int, Order> Data = new Dictionary<int, Order>();

        public static void Main(string[] args)
        {
            Data.Add(0, new Order
            {
                CustomerName = "Kroger",
                OrderId = 0,
                OrderType = OrderType.Standard,
                CreatedDate = new DateTime(2020, 9, 30),
                CreatedByUserName = "Matt",
                Uid = new Guid("e3368e87-0458-4d1e-a46f-b82a65878a88"),
            });
            Data.Add(1, new Order
            {
                CustomerName = "Target",
                OrderId = 1,
                OrderType = OrderType.PurchaseOrder,
                CreatedDate = new DateTime(2020, 11, 1),
                CreatedByUserName = "Shay",
                Uid = new Guid("00253bd5-eca6-4e23-b3cb-224020e9df90"),
            });
            Data.Add(2, new Order
            {
                CustomerName = "Walmart",
                OrderId = 2,
                OrderType = OrderType.ReturnOrder,
                CreatedDate = new DateTime(2020, 10, 19),
                CreatedByUserName = "David",
                Uid = new Guid("b2fc790a-1c2e-4499-913c-cd1d3ae1a423"),
            });
            Data.Add(3, new Order
            {
                CustomerName = "Aldi",
                OrderId = 3,
                OrderType = OrderType.SaleOrder,
                CreatedDate = new DateTime(2020, 5, 15),
                CreatedByUserName = "Josh",
                Uid = new Guid("ee168778-47ab-42be-8c70-b47a1693512f"),
            });
            Data.Add(4, new Order
            {
                CustomerName = "Meijer",
                OrderId = 4,
                OrderType = OrderType.TransferOrder,
                CreatedDate = new DateTime(2020, 12, 12),
                CreatedByUserName = "Alex",
                Uid = new Guid("a547c8b8-98a5-48ea-9907-5895c0321066"),
            });

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}