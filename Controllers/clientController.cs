using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apartment_brokerage.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [Route("api/[controller]")]
    [ApiController]
    public class clientController : ControllerBase
    {
        private static new List<Client> clients = new List<Client> {
                new Client { id=5656, name = "sari", phone = "0527114114",email="dfsd@gmail.com" },
                new Client { id=6576765, name = "shoshi", phone = "0527114114",email="dfsd@gmail.com" },
            };
        // GET: api/<clientController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return clients;
        }

        // GET api/<clientController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<clientController>
        [HttpPost]
        public Client Post([FromBody] Client value)
        {
            clients.Add(value);
            return value;
        }

        // PUT api/<clientController>/5
        [HttpPut("{id}")]
        public Client Put(int id, [FromBody] Client value)
        {
            var index = clients.FindIndex(e => e.id == id);
            
            clients[index].name = value.name;
            clients[index].phone = value.phone;
            clients[index].email = value.email;
       
            return clients[index];
        }

        // DELETE api/<clientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = clients.FindIndex(e => e.id == id);
            clients.Remove(clients[index]);
        }
    }
}
