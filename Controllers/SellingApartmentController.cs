using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apartment_brokerage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellingApartmentController : ControllerBase
    {
        private static new List<SellingApartment> sa = new List<SellingApartment> {
                new SellingApartment {id = 7, idBueyr = 1, nameBueyr = "Yakov", idSeller = 5, nameSeller = "moshe", idApartment = 9, phoneBuyer = "0541256754", phoneSeller = "0541489656"}
        };

        // GET: api/<SellingApartmController>
        [HttpGet]
        public IEnumerable<SellingApartment> Get()
        {
            return sa;
        }

        // POST api/<SellingApartmController>
        [HttpPost]
        public SellingApartment Post([FromBody] SellingApartment value)
        {
            sa.Add(value);
            return value;
        }

        // PUT api/<SellingApartmController>/5
        [HttpPut("{id}")]
        public SellingApartment Put(int id, [FromBody] SellingApartment value)
        {
            var index = sa.FindIndex(s => s.id == id);
            sa[index].idBueyr = value.idBueyr;
            sa[index].nameBueyr = value.nameBueyr;
            sa[index].idSeller = value.idSeller;
            sa[index].nameSeller = value.nameSeller;
            sa[index].idApartment = value.idApartment;
            sa[index].phoneBuyer = value.phoneBuyer;
            sa[index].phoneSeller = value.phoneSeller;
            return sa[index];
        }

        // DELETE api/<SellingApartmController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = sa.FindIndex(s => s.id == id);
            sa.Remove(sa[index]);
        }
    }
}
