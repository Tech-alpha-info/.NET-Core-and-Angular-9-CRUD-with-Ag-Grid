using System.Collections.Generic;
using System.Linq;
using CustomerServer.Context;
using CustomerServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly CustomerContext CusDetails;
        public CustomerController(CustomerContext customerContext)
        {
            CusDetails = customerContext;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var data = CusDetails.Customer.ToList();
            return data;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer obj)
        {
            var data = CusDetails.Customer.Add(obj);
            CusDetails.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer obj)
        {
            var data = CusDetails.Customer.Update(obj);
            CusDetails.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = CusDetails.Customer.Where(a => a.CusId == id).FirstOrDefault();
            CusDetails.Customer.Remove(data);
            CusDetails.SaveChanges();
            return Ok();

        }
    }
}
