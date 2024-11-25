using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Core.Services
{
    public interface ISellingApartmentService
    {
        public List<SellingApartment> GetList();    
        public SellingApartment GetSellingApartmentsById(int id);
        public SellingApartment AddSellingApartments(SellingApartment SellingApartment);

        public SellingApartment UpdateSellingApartments(int id, SellingApartment SellingApartment);
        public void DeleteSellingApartments(int id);

    }
}
