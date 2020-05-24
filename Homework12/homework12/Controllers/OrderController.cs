using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace homework12.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly OrderContext orderDatabase;
        public OrderController(OrderContext context) {
            this.orderDatabase = context;
        }
        
        // GET请求: api/<controller>
        [HttpGet]
        public ActionResult<List<Order>> GetOrder(string merName,string cusName,float? totalAmount) 
        {
            IQueryable<Order> query = orderDatabase.Orders;

            if (cusName != null) { 
                query=query.Where(o => o.Customer.Name == cusName); 
            }
            if (totalAmount != null) {
                query = query.Where(o => o.Items.Sum(item => item.GoodsItem.Price * item.Quantity) > totalAmount);
            }
            if (merName != null)
            {
                query = query.Where(o => o.Items.Count(i => i.GoodsItem.Name == merName) > 0);
            }
            return query.ToList();
        
        }


        // GET请求 api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(string id)
        {
            var order = orderDatabase.Orders.FirstOrDefault(o => o.Id == id);
            if (order==null)  return NotFound();
            return order;
        }


        // PUT请求 api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult<Order> Put(string id,Order order)
        {
            if (id != order.Id) 
            { 
                return BadRequest("Id cannot be modified");
            }

            try 
            {
                orderDatabase.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                orderDatabase.SaveChanges();
            }
            catch (Exception e) 
            {
                string error = e.Message;
                if (e.InnerException != null) 
                    error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();

        }

        // POST请求 api/<controller>
        [HttpPost]
        public ActionResult<Order> Post(Order order)
        {
            try
            {
                orderDatabase.Orders.Add(order);
                orderDatabase.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }


        // DELETE请求 api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try {
                var order = orderDatabase.Orders.FirstOrDefault(t => t.Id == id);
                if (order != null) {
                    orderDatabase.Remove(order);
                    orderDatabase.SaveChanges();
                }
            }
            catch (Exception e) {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
