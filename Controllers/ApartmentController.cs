using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apartment_brokerage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        // GET: api/<ApartmentController>
        private static new List<Apartment> apartments = new List<Apartment> {
                new Apartment { id=5656, name = "sari",description="dfgdsgf",numOfRooms=4,street="fgfgf",number=54,city="dfds",size=234f,phoneNumber="45354",email="fdfsd@gmail.com",price=546464 },
            
            };
        // GET: api/<clientController>
        [HttpGet]
        public IEnumerable<Apartment> Get()
        {
            return apartments;
        }

        // GET api/<clientController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<clientController>
        [HttpPost]
        public Apartment Post([FromBody] Apartment value)
        {
            apartments.Add(value);
            return value;
        }

        // PUT api/<clientController>/5
        [HttpPut("{id}")]
        public Apartment Put(int id, [FromBody] Apartment value)
        {
            var index = apartments.FindIndex(e => e.id == id);

            apartments[index].name = value.name;
            apartments[index].description = value.description;
            apartments[index].numOfRooms = value.numOfRooms;
            apartments[index].street = value.street;
            apartments[index].number = value.number;
            apartments[index].city = value.city;
            apartments[index].size = value.size;
            apartments[index].phoneNumber = value.phoneNumber;
            apartments[index].email = value.email;
            apartments[index].price = value.price;

            return apartments[index];
        }

        // DELETE api/<clientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = apartments.FindIndex(e => e.id == id);
            apartments.Remove(apartments[index]);
        }
    }
}
