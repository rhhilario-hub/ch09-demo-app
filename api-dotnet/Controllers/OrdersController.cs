using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using api_dotnet.Models;

namespace api_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly DataContext dataContext;

        public OrdersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public IEnumerable<Order> Get([FromQuery]OrderStatus? status)
        {
            return status == null
                ? dataContext.Orders
                : dataContext.Orders
                    .Wher(o => o.Status == status)
                    .ToList();
        }            

        [HttpPost]
        public void AddOrder(Order order)
        {
            dataContext.Orders.Add(order);
            dataContext.SaveChanges();
        }
    }
}