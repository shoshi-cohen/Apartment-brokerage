using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Core.Services
{
    public interface IApartmentService
    {
        public List<Apartment> GetList();
        public Apartment AddApartments(Apartment SellingApartment);
        public Apartment GetApartmentsById(int id);
        public Apartment UpdateApartments(int id, Apartment SellingApartment);
        public void DeleteApartments(int id);
    }
}
