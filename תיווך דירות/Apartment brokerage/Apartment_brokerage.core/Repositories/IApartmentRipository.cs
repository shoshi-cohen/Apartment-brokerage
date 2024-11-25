using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Core.Repositories
{
    public interface IApartmentRipository
    {
        public List<Apartment> GetAll();
        public Apartment GetById(int id);
        public Apartment AddApartment(Apartment s);

        public Apartment UpdateApartment(int id, Apartment Apartment);
        public void DeleteApartment(int id);
    }
}
